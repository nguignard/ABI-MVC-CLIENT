using ABIEnCouches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{

    /// <summary>
    /// Classe DAO de fonctions statics permettant d'acceder aux entitées 
    /// </summary>
    public class Dao
    {

        /// <summary>
        /// instancieCollaborateurs: créer la liste des collaborateurs depuis la BD
        /// </summary>
        /// <param name="listeCollaborateurs"></param>
        public static void instancieCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            if (DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            //var query = from a in DonneesDao.DbContextEntreprise.CollaborateursESet
            //            select a;
                       
            Collaborateur leCollab = null;

            foreach(CollaborateursE item in DonneesDao.DbContextEntreprise.CollaborateursESet)
            {
                leCollab = new Collaborateur(item.civiliteE, item.nomE, item.prenomE, item.situationE, item.actifE);

                InstancieContratsCollaborateur(leCollab);
                listeCollaborateurs.AddCollaborateur(leCollab);
            }
        }

        /// <summary>
        /// InstancieContratsCollaborateur: ajoute les contrats d'un collaborateur à partir de la base de donnee
        /// </summary>
        /// <param name="leCollaborateur"></param>
        public static void InstancieContratsCollaborateur(Collaborateur leCollaborateur)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }

            var query = from b in DonneesDao.DbContextEntreprise.ContratTypeESet
                        where b.CollaborateurEntity.matriculeE == leCollaborateur.Matricule
                        select b;

            ContratType LeContratType = null;

            foreach(ContratTypeE item in query)
            {
                if(item is CdiE)
                {
                    LeContratType = new Cdi(item.idContratE, item.dateDebutE,item.qualificationE.Trim(),item.statutE.Trim(),item.salaireE);
                }

                if(item is CddE)
                {
                    LeContratType = new Cdd(item.idContratE, item.dateDebutE, item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE, ((CddE)item).dateFinE, ((CddE)item).motifE.Trim());
                }

                if(item is StageE)
                {
                    LeContratType = new Stagiaire(item.idContratE, ((StageE)item).ecoleE.Trim(), ((StageE)item).missionE.Trim(), ((StageE)item).motifE.Trim(), item.dateDebutE, ((StageE)item).dateFinE , item.qualificationE.Trim(), item.statutE.Trim(), item.salaireE);
                }
                leCollaborateur.AddContrat(LeContratType);

            }

         
            


        }




        /// <summary>
        /// Ajoute un Collaborateur avec sa liste de contrats à la liste des collaborateurs Entity FrameWork
        /// </summary>
        /// <param name="leCollaborateur"></param>
        public static void AddNewCollaborateur(Collaborateur leCollaborateur)
        {
            if(DonneesDao.DbContextEntreprise == null)
            {
                DonneesDao.DbContextEntreprise = new EntrepriseContainer();
            }
            ContratType ct = leCollaborateur.ContratInitial();
            CollaborateursE collaborateurE = new CollaborateursE(leCollaborateur.Matricule, leCollaborateur.Civilite, leCollaborateur.NomCollab, leCollaborateur.PrenomCollab, leCollaborateur.SituationFamiliale, leCollaborateur.Photo, leCollaborateur.Actif);
            ContratTypeE contratE = toContratE(ct);
            contratE.CollaborateurEntity = collaborateurE; //Ajoute le contrat initial au collaborateur

            collaborateurE.ContratTypeE.Add(contratE);
            try
            {
                DonneesDao.DbContextEntreprise.CollaborateursESet.Add(collaborateurE);
                DonneesDao.DbContextEntreprise.SaveChanges();
            }
            catch (Exception )
            {
                //DonneesDao.DbContextEntreprise.CollaborateursESet.Remove(collaborateurE);
                //DonneesDao.DbContextEntreprise.SaveChanges();

                throw new Exception("le nouveau collaborateur n'a pu etre mis en DB");
            }
        }


        /// <summary>
        /// toContratE transforme un contrat Metier en contrat entityFrameWork
        /// </summary>
        /// <param name="unContrat"></param>
        /// <returns></returns>
        public static ContratTypeE toContratE(ContratType unContrat)
        {
            ContratTypeE contratE = null;

            if(unContrat is Cdi)
            {
                contratE = new CdiE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat);
                            }
            else if(unContrat is Cdd)
            {
                contratE = new CddE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat,
                    ((Cdd)unContrat).DateFinContrat, ((Cdd)unContrat).Motif);
            }
            else if(unContrat is Stagiaire)
            {
                contratE = new StageE(unContrat.IdContrat, unContrat.DateDebutContrat, unContrat.Qualification, unContrat.Statut, unContrat.SalaireContractuel, unContrat.FinReelContrat,
                   ((Stagiaire)unContrat).DateFinContrat, ((Stagiaire)unContrat).Motif,
                   ((Stagiaire)unContrat).Ecole, ((Stagiaire)unContrat).Mission
                   );
            }
            return contratE;
        }




    }
}
