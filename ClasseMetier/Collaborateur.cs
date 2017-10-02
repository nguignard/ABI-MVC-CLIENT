/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ABIEnCouches
{
    /// <summary>
    /// Classe Metier Collaborateur, gere la liste des contrats et des avenants d'un collaborateur
    /// </summary>
    [DataContract]
    [Serializable]
    public class Collaborateur
    {
        private int matricule;
        private String civilite;
        private string nomCollab;
        private string prenomCollab;
        private string situationFamiliale;
        private string photo;
        private bool actif;

        private SortedDictionary<int, ContratType> contrats; // Liste dictionnaire des collaborateurs elle est privéee et innaccessible
        private DataTable dtContrats; // pour affichage de la liste des contrats
        private SortedDictionary<DateTime, HistoriqueAugmentation> augmentations;

        //CONSTRUCTEURS-------------------------------------------------------------------------------

        /// <summary>
        /// Collaborateur: Constructeur Complet
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="civilite"></param>
        /// <param name="nomCollab"></param>
        /// <param name="prenomCollab"></param>
        /// <param name="situationFamillial"></param>
        /// <param name="actif"></param>
        public Collaborateur( String civilite, String nomCollab, String prenomCollab, String situation, bool actif)
        {
            this.Matricule = GetNewMatricule();
            this.Civilite = civilite;
            this.NomCollab = nomCollab;
            this.PrenomCollab = prenomCollab;
            this.SituationFamiliale = situation;
            this.Actif = actif;

            this.contrats = new SortedDictionary<int, ContratType>();
            this.dtContrats = new DataTable();                      // Instancie la liste des contrats pour visualisation, ainsi que ces colonnes a afficher
            dtContrats.Columns.Add("IDCONTRAT", typeof(int));
            dtContrats.Columns.Add("TYPECONTRAT", typeof(String));
            dtContrats.Columns.Add("DATEDEBUT", typeof(String));
        }



        //GETTER-SETTERS----------------------------------------------------------------------

        /// <summary>
        /// Accesseur Matricule, Matricule ne peut être null
        /// </summary>
        /// 
        [DataMember]
        public int Matricule
        {
            get
            {
                return matricule;
            }
            private set
            {
                if (value <=0)
                {
                    throw new Exception("Matricule obligatoire et >0 ");
                }
                else
                {
                    this.matricule = value;
                }
            }
        }

        /// <summary>
        /// Accesseur Civilité, ne peut être que M ou Mme
        /// </summary>
        /// 
        [DataMember]
        public String Civilite
        {
            get
            {
                return civilite;
            }
            set
            {
               if (value.ToUpper() != "M" && value.ToUpper() != "F")
                    {
                        throw new Exception(" le champs cvilité doit être M ou F");
                    }
                    else
                    {
                        this.civilite = value.Trim().ToUpper();
                    }
            }
        }

        /// <summary>
        /// Accesseur NomCollab
        /// </summary>
        /// 
        [DataMember]
        public string NomCollab
        {
            get
            {
                return nomCollab;
            }
            set
            {
                if (value.Trim().ToUpper() == "")
                {
                    throw new Exception("vous n'avez pas rentrer de nom pour ce collaborateur");
                }
                else
                {
                    this.nomCollab = value.Trim().ToUpper();
                }
            }
        }

        /// <summary>
        /// Accesseur PrénomCollab, ne peut être vide
        /// </summary>
        /// 
        [DataMember]
        public string PrenomCollab
        {
            get
            {
                return prenomCollab;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("vous n'avez pas rentrer de prénom pour ce collaborateur");
                }
                else
                {
                    this.prenomCollab = value.Trim();
                }
            }
        }

        /// <summary>
        /// Accesseur SituationFamiliale
        /// </summary>
        [DataMember]
        public string SituationFamiliale
        {
            get
            {
                return situationFamiliale;
            }
            set
            {
                if(value == "CELIBATAIRE" || value == "MARIE" || value == "DIVORCE")
                {
                    this.situationFamiliale = value;
                }
                else
                {
                    throw new Exception("situation Familiale incorrecte");
                }
            }
        }

        /// <summary>
        /// Accesseur Photo
        /// </summary>
        [DataMember]
        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                if (this.photo != value)
                    this.photo = value;
            }
        }

        /// <summary>
        /// Accesseur Actif
        /// </summary>
        /// 
        [DataMember]
        public bool Actif
        {
            get
            {
                return actif;
            }
            set
            {
                if (this.actif != value)
                    this.actif = value;
            }
        }


        //FONCTIONS---------------------------------------------------------------------------
        /// <summary>
        /// ContratInitial , permet de retrouver le contrat initial pour affichage, pour des raisons de privacy
        /// </summary>
        /// <returns></returns>
        public ContratType ContratInitial()
        {
            DateTime t = DateTime.MaxValue;
            ContratType x =null;

            //Rechercher Date contrat initial
            foreach (ContratType c in contrats.Values)
            {
                if (t > c.DateDebutContrat)
                {
                    t = c.DateDebutContrat;
                }
            }
            if (t != null)
            {
                //Retourner contrat Initial
                foreach (ContratType c in contrats.Values)
                {
                    if (c.DateDebutContrat == t)
                    {
                        x = RestituerContrat(c.IdContrat);
                    }
                }
                return x;
            }
            else
            {
                throw new Exception ("il n'y a pas de contrat initial!!");
            }
        }

        /// <summary>
        /// GetNewMatricule, reccupere le nouveau matricule pour un collaborateur. généré en C# et nonj par la base
        /// </summary>
        /// <returns></returns>
        public int GetNewMatricule()
        {
           return Donnees.CompteurCollaborateur++;
        }

        /// <summary>
        /// onGoingCDI permet de savoir si unCDI est en cours
        /// </summary>
        /// <returns></returns>
        private bool onGoingContrat(ContratType newContrat)
        {
            bool b = true;
            //foreach (ContratType contrat in contrats.Values)
            //{
            //    if ((contrat is Cdi && (contrat.FinReelContrat == null))
            //        || (contrat is ContratTemporaire && (((ContratTemporaire)(contrat)).FinReelContrat > newContrat.DateDebutContrat)))
            //    {
            //        b = false;
            //    }

            //}
            return b;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Matricule " + this.Matricule + " Civilite " + this.Civilite + " Nom " + this.NomCollab + " Prénom " + this.PrenomCollab;
        }
        /// <summary>
        /// permet d'envoyer au services Web une liste de collaborateurs
        /// </summary>
        /// <returns> List<Collaborateur></returns>
        public List<ContratType> ContratToList()
        {
            List<ContratType> l = new List<ContratType>();
            foreach (ContratType item in contrats.Values)
            {
                l.Add(item);
            }
            return l;
        }






        //GESTION COLLECTION D'AUGMENTATIONS- NON GERE-------------------------------------------------------------------------------------

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation> GetAugmentations()
        {
            if (augmentations == null)
                augmentations = new System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation>();
            return augmentations;
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAugmentation(HistoriqueAugmentation newAugmentation)
        {
            if (newAugmentation == null)
            {
                throw new Exception("la nouvelle augmentation doit être renseignée");
            }
            else if (this.augmentations == null)
            {
                this.augmentations = new System.Collections.Generic.SortedDictionary<DateTime, HistoriqueAugmentation>();
            }
            else if (newAugmentation.MontantAugmentation < 0)
            {
                throw new Exception("l'augmentation ne doit pas être < 0");
            }
            else
            {
                //il faudrai verifier si la duree est >3 ans
                this.augmentations.Add(newAugmentation.DateAugmentation,newAugmentation);
            }
        }

       //NonGéré
        public HistoriqueAugmentation RestituerAugmentation(DateTime date)
        {
            if (!augmentations.ContainsKey(date))
            {
                throw new Exception("cet AVENANT n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return augmentations[date];
            }
        }


        //GESTION COLLECTION DE CONTRATS--------------------------------------------------------------------------------

        /// <pdGenerated>default Add</pdGenerated>
        public void AddContrat(ContratType newContrat)
        {
            if (controlAddContrats(newContrat))
            {
                this.contrats.Add(newContrat.IdContrat, newContrat);
            }
            else
            {
                throw new Exception("erreur générale pour entrer un contrat dans la collection");
            }

        }

        /// <summary>
        ///  RestituerContrat(int idContrat) 
        /// </summary>
        /// <param name="idContrat"></param>
        /// <returns></returns>
        public ContratType RestituerContrat(int idContrat)
        {
            if (!contrats.ContainsKey(idContrat))
            {
                throw new Exception("ce contrat n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return contrats[idContrat];
            }
        }

        ///// <pdGenerated>default removeAll</pdGenerated>
        //public void RemoveAllContratType()
        //{
        //    if (contrats != null)
        //        contrats.Clear();
        //}

        /// <summary>
        /// controlAddContrats controle la validite du contrat vis a vis des autres contrat avant de l'ajouter
        /// </summary>
        /// <param name="newContrat"></param>
        /// <returns></returns>
        private bool controlAddContrats(ContratType newContrat)
        {
            bool b = true;
            String st = "le nouveau contrat ne peut être ajouté: ";

            if (newContrat == null)
            {
                b = false;
                throw new Exception(st + "le contrat est null ");
            }

            if (this.contrats == null)
            {
                this.contrats = new System.Collections.Generic.SortedDictionary<int, ContratType>();
            }

            if (this.contrats.ContainsKey(newContrat.IdContrat))
            {
                b = false;
                throw new Exception(st + "le contrat existe deja dans la collection");
            }

            if (onGoingContrat(newContrat))
            {
                //b = false;
                //throw new Exception(st + " un contrat est déja en cours");
            }
            return b;
        }

        /// <summary>
        /// ListerContrats renvoie la liste des contrats du collaborateur. cette liste est public contrairement au dictionnary
        /// </summary>
        /// <returns></returns>
        public DataTable ListerContrats()
        {
            dtContrats.Clear();
            DataRow dr;
            foreach(ContratType contrat in contrats.Values)
            {
                string s = contrat.GetType().ToString();
                int found = s.IndexOf(".");

                dr = dtContrats.NewRow();
                dr[0] = contrat.IdContrat;
                dr[1] = s.Substring(found+1).ToUpper();
                dr[2] = contrat.DateDebutContrat.Date.ToString();
                dtContrats.Rows.Add(dr);
            }
            return this.dtContrats;
        }

    }
}