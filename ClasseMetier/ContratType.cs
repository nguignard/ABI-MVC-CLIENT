/***********************************************************************
 * Module:  ContratType.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratType
 ***********************************************************************/

using System;
using System.Runtime.Serialization;


namespace ABIEnCouches
{

    /// <summary>
    /// Classe ContratType Abstraite, de tout les contrats
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    [KnownType(typeof(Cdi))]
    [KnownType(typeof(ContratTemporaire))]
    [KnownType(typeof(Cdd))]
    [KnownType(typeof(Stagiaire))]
    public abstract class ContratType
    {
        //ATTRIBUTS------------------------------------------------------------
       
        protected int idContrat;
        protected DateTime dateDebutContrat;
        protected String qualification;
        protected String statut;
        protected Decimal salaireContractuel;
        protected DateTime? finReelContrat;

        protected System.Collections.Generic.SortedDictionary<int,Avenant> avenants; //liste d'avenants dans un contrat


        //CONSTRUCTEUR -------------------------------------------------------
        /// <summary>
        /// Constructeur de ContratType 
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        public ContratType(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel)
        {
            this.IdContrat = GetNewIdContrat();
            this.DateDebutContrat = dateDebutContrat;
            this.Qualification = qualification;
            this.Statut = statut;
            this.SalaireContractuel = salaireContractuel;
        }




        //GET SET--------------------------------------------------------------

        /// <summary>
        /// PPT IdContrat
        /// </summary>
        /// 
        [DataMember]
        public int IdContrat
        {
            get
            {
                return idContrat;
            }
            private set
            {
                if (this.idContrat < 0)
                {
                    throw new Exception("l'idContrat est obligatoire > 0");
                }
                else
                {
                    this.idContrat = value;
                }

            }
        }

        /// <summary>
        /// getset DateDebutContrat
        /// </summary>
        /// 
        [DataMember]
        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            private set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }

        [DataMember]
        public String Qualification
        {
            get
            {
                return qualification;
            }
            private set
            {
                if (this.qualification != value)
                    this.qualification = value;
            }
        }

        [DataMember]
        public String Statut
        {
            get
            {
                return statut;
            }
            private set
            {
                if (this.statut != value)
                    this.statut = value;
            }
        }

        [DataMember]
        public decimal SalaireContractuel
        {
            get
            {
                return salaireContractuel;
            }

           private set
            {
                if (value<0 )
                { throw new Exception("le salaire doit être compris entre 0 et 3000"); }
                 else
                    { 
                this.salaireContractuel = value;
                }
            }
        }

        /// <summary>
        /// FinReelContrat: contrairement a une fin de contrat temporaire. 
        /// nullable, sera actif avec une fonction clôturer
        /// </summary>
        /// 
        [DataMember]
        public DateTime? FinReelContrat
        {
            get
            {
                return finReelContrat;
            }
            set
            {
                if (value > this.DateDebutContrat)
                    this.finReelContrat = value;
            }
        }

        /// <summary>
        /// GetIdContrat() nouvelId d'un contrat type
        /// </summary>
        /// <returns></returns>
        public int GetNewIdContrat()
        {
            return Donnees.CompteurContrat++;
        }





        //GESTION DES AVENANTS // NON GERE----------------------------------------------
     
        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.Generic.SortedDictionary<int, Avenant> ListerAvenants()
        {
            if (avenants == null)
                avenants = new System.Collections.Generic.SortedDictionary<int, Avenant>();
            return avenants;
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAvenant(Avenant newAvenant)
        {

            if (this.avenants == null)
            {
                this.avenants = new System.Collections.Generic.SortedDictionary<int, Avenant>();
            }

            if (newAvenant == null)
            {
                throw new Exception("le nouvel Avenant doit être renseignée");
            }

            if (newAvenant.IdAvenant < 0)
            {
                throw new Exception("l'ID de l'Avenant ne doit pas être < 0");
            }
            else if (avenants.ContainsKey(newAvenant.IdAvenant))
            {
                throw new Exception("l'ID de l'Avenant Existe déjà");
            } 
            else
            {
                this.avenants.Add(newAvenant.IdAvenant,newAvenant);
            }
        }

        /// <summary>
        /// RestituerAvenant(int idAvenant)
        /// </summary>
        /// <param name="idAvenant"></param>
        /// <returns></returns>
        public Avenant RestituerAvenant(int idAvenant)
        {
            if (!avenants.ContainsKey(idAvenant))
            {
                throw new Exception("cet AVENANT n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return avenants[idAvenant];
            }
        }



        //FONCTIONS-------------------------------------------------------------------------

        /// <summary>
        /// cloturerContrat // NON GERE
        /// </summary>
        public DateTime? CloturerContrat
        {
            get
            {
                return finReelContrat;
            }
            set
            {
                if (value > this.DateDebutContrat)
                {
                    this.finReelContrat = value;
                }
                else
                {
                    throw new Exception("la date de fin de contrat doit être > à la date de début de contrat");
                }
            }
        }

        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "idContrat "+ idContrat+ " qualification " + " statut "+ statut ;
        }


        /// <summary>
        /// Fonction d'affichage du type de contrat 
        /// </summary>
        /// <returns>CDD, CDI, Stage...</returns>
        public string TypeContrat()
        {
            string s = this.GetType().ToString();
            Char charRange = '.';
            int startIndex = s.IndexOf(charRange) + 1;
            int endIndex = s.Length - 1;
            int l = endIndex - startIndex + 1;
            return s.Substring(startIndex, l);
        }




    }
}