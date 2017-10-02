using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIEnCouches;
using ClassesDAO;

namespace MetierServicesApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceAbi" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceAbi.svc ou ServiceAbi.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceAbi : IServiceAbi
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


       public  IList<Collaborateur> GetCollaborateurs()
        {
            //instancie uneliste de collaborateurs et la rempli des collaborateures de la BD
            Collaborateurs listeCollaborateurs = new Collaborateurs();
            Dao.instancieCollaborateurs(listeCollaborateurs);

            return listeCollaborateurs.CollaborateurToList();
        }

        public string addCollaborateur(Collaborateur newCollaborateur)
        {
            string retour = "";
            try
            {
                Dao.AddNewCollaborateur(newCollaborateur);
            }
            catch(Exception e)
            {
                retour = "Erreur d'ajout stagiaire " +e.Message;
            }

            return retour;
        }




        public IList<ContratType> GetContratsCollaborateur(string matricule)
        {
            Collaborateurs listeCollaborateurs = new Collaborateurs();
            Dao.instancieCollaborateurs(listeCollaborateurs);


            Collaborateur Collabo = listeCollaborateurs.RestituerCollaborateur(int.Parse(matricule));


            return Collabo.ContratToList();
        }


        /// <summary>
        /// NOT IMPLEMENTED---------------------------------------------------------------------------------
        /// </summary>
        /// <param name="newCollaborateur"></param>
        /// <returns></returns>
        //string UpdateCollaborateur(Collaborateur newCollaborateur)
        //{
        //    string retour = "";

        //    try
        //    {
        //        Dao.m(newCollaborateur);

        //    }
        //    catch (Exception e)
        //    {
        //        retour = "Erreur d'ajout stagiaire";
        //    }

        //    return retour;
        //}



        //string AddContratCollaborateur(Collaborateur unCollaborateur, ContratType unNouveauContrat)
        //{



        //}






    }
}
