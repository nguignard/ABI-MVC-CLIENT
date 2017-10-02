using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;

namespace ABIEnCouches
{

    /// <summary>
    /// Classe Metier Collaborateurs , gère la collection des collaborateurs
    /// </summary>
    /// 
    [Serializable]
    [DataContract]
    public class Collaborateurs
    {
        private  SortedDictionary<int, Collaborateur> listCollab;
        private  DataTable dtCollab ;

        /// <summary>
        /// Constructeurs Collaborateurs, instancie la liste de collaborateurs (privee) et la dataTable de visualisation (public) mais non complete
        /// </summary>
        public Collaborateurs()
        {
            listCollab = new SortedDictionary<int, Collaborateur>();
            dtCollab = new DataTable();
                dtCollab.Columns.Add("MATRICULE", typeof(int));
                dtCollab.Columns.Add("NOM", typeof(String));
                dtCollab.Columns.Add("PRENOM", typeof(String));
        }


        //FONCTIONS-----------------------------------------------------------
        /// <summary>
        /// ListerCollaborateurs(), rnvoie la liste des collaborateurs pour visualisation
        /// </summary>
        /// <returns></returns>
        public DataTable ListerCollaborateurs()
        {
            dtCollab.Clear();
            DataRow dr;
            foreach (Collaborateur collab in listCollab.Values)
            {
                dr = dtCollab.NewRow();
                dr[0] = collab.Matricule;
                dr[1] = collab.NomCollab;
                dr[2] = collab.PrenomCollab;
                dtCollab.Rows.Add(dr);
            }
            return this.dtCollab;
        }

        /// <summary>
        /// permet d'envoyer au services Web une liste de collaborateurs
        /// </summary>
        /// <returns> List<Collaborateur></returns>
        public List<Collaborateur> CollaborateurToList()
        {
            List<Collaborateur> l = new List<Collaborateur>();
            foreach(Collaborateur item in listCollab.Values)
            {
                l.Add(item);
            }
            return l;
        }



        /// <summary>
        /// AddCollaborateur, rajoute un collaborateur au dictionnaire des collaborateur
        /// </summary>
        /// <param name="newCollab"></param>
        public void AddCollaborateur(Collaborateur newCollab)
        {
            if (controlAddCollab(newCollab))
            {
                this.listCollab.Add((int)newCollab.Matricule, newCollab);
            }
            else
            {
                throw new Exception("erreur générale pour entrer un contrat dans la collection");
            }

        }


        /// <summary>
        /// removeCollaborateur, ne sert que en cas d'echec (try/catch) pour rentrer un collaborateur dans la liste
        /// </summary>
        /// <param name="matricule"></param>
        /// <param name="leDemandeur"></param>
        public void removeCollaborateur(int matricule, string leDemandeur)
        {
            if(leDemandeur == "ABIEnCouches.ctrlListerCollaborateur") // protection: ne peut etre appele que par le controleur ABIEnCouches.ctrlListerCollaborateur
                if (listCollab.ContainsKey(matricule))
            {
                this.listCollab.Remove(matricule);
            }

        }

        /// <summary>
        /// RestituerCollaborateur(int matricule)
        /// </summary>
        /// <param name="matricule"></param>
        /// <returns></returns>
        public Collaborateur RestituerCollaborateur(int matricule)
        {
            if (!this.listCollab.ContainsKey(matricule))
            {
                throw new Exception("ce contrat n'existe pas et ne peut donc pas être restitué");
            }
            else
            {
                return this.listCollab[matricule];
            }
        }

        /// <summary>
        /// controlAddContrats controle la validite du collaborateur ajouté dans sa liste
        /// </summary>
        /// <param name="newContrat"></param>
        /// <returns></returns>
        private  bool controlAddCollab(Collaborateur newCollaborateur)
        {
            bool b = true;
            String st = "le nouveau COLLABORATEUR ne peut être ajouté: ";

            if (newCollaborateur == null)
            {
                b = false;
                throw new Exception(st + "il est null ");
            }

            if (this.listCollab == null)
            {

                this.listCollab = new System.Collections.Generic.SortedDictionary<int, Collaborateur>();
            }

            if (newCollaborateur.Matricule <= 0)
            {
                b = false;
                throw new Exception(st + "le Matricule du collaborateur doit etre >0");
            }
            else if (this.listCollab.ContainsKey((int)newCollaborateur.Matricule))
            {
                b = false;
                throw new Exception(st + "le contrat existe deja dans la collection");
            }
            return b;
        }


        //NON GERE
        private void modifierCollaborateur(Collaborateur newCollaborateur)
        {


        }


    }
}
