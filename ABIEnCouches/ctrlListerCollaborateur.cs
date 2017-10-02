using ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{

    /// <summary>
    /// ctrlListerCollaborateur classe controlant l'instanciation et la visualisation de la liste de collaborateur, l'affichage d'un collaborateur
    /// </summary>
    public class ctrlListerCollaborateur
    {
        Collaborateurs listeCollaborateurs = new Collaborateurs();
        //private Collaborateurs listeCollaborateurs;
        private frmListCollab leForm;

        /// <summary>
        /// ctrlListerCollaborateur : constructeur, instancie a partir de la base de donnee la liste des collaborateurs et affiche cette liste sous forme de datagrid
        /// evenement double click permet de visualiser un collaborateur
        /// </summary>
        public ctrlListerCollaborateur()
        {
            Dao.instancieCollaborateurs(listeCollaborateurs);

            //this.instancieCollaborateurs();
            this.leForm = new frmListCollab(this.listeCollaborateurs);
            this.leForm.afficheCollaborateurs(this.listeCollaborateurs);

            this.leForm.grdCollaborateurs.CellContentClick  += new DataGridViewCellEventHandler(this.grdCollaborateurs_DoubleClick);
            //this.leForm.btnAjouter. += new EventHandler(this.btnAjouter_Click);
            this.leForm.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.leForm.MdiParent = frmMDI.Ref;
            this.leForm.Show();
        }

        /// <summary>
        /// evenement btnAjouter_Click: tente d'ajouter un collaborateur à la liste des collaborateurs metier puis Dao.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ctrlAjouterCollaborateur ctrl = new ctrlAjouterCollaborateur();

            if(ctrl.Result == DialogResult.OK)
            {
                try
                {
                    this.listeCollaborateurs.AddCollaborateur(ctrl.LeCollaborateur);

                    try
                    {
                        Dao.AddNewCollaborateur(ctrl.LeCollaborateur);

                    }
                    catch (Exception ex)
                    {
                        this.leForm.LeveErreur(ex);
                        this.listeCollaborateurs.removeCollaborateur(ctrl.LeCollaborateur.Matricule, typeof(ctrlListerCollaborateur).ToString());
                        //Dao.RemoveCollaborateur(ctrl.LeCollaborateur.Matricule, typeof(ctrlListerCollaborateur).ToString());

                    }
                }
                catch (Exception ex)
                {
                    this.leForm.LeveErreur(ex);
                }
                
                this.leForm.afficheCollaborateurs(this.listeCollaborateurs);
                Exception valid = new Exception("Collaborateur Ajouté!!!");
                
                this.leForm.LeveErreur(valid);
            }
        }

        /// <summary>
        /// grdCollaborateurs_DoubleClick: reccupere l'ID d'un collaborateur dans la liste des collaborateurs et lance le form de visualisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCollaborateurs_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Collaborateur leCollaborateur;
            Int32 laCle; //matriculle
            laCle = (Int32)leForm.grdCollaborateurs.CurrentRow.Cells[0].Value;

            leCollaborateur = this.listeCollaborateurs.RestituerCollaborateur(laCle);
            ctrlVisuModifCollaborateur ctrlVisu = new ctrlVisuModifCollaborateur(leCollaborateur);
            
            this.leForm.afficheCollaborateurs(listeCollaborateurs);
        }


        /// <summary>
        /// initialiseListeCollab() : en dur
        /// </summary>
        private void instancieCollaborateurs()
        {
            //listeCollaborateurs = new Collaborateurs();
            //Collaborateur collaborateur = new Collaborateur("M", "DUPOND", "Roger", "MARIE", true);
            //Cdd contrat = new Cdd(new DateTime(2010, 5, 5).Date, "Chef de Projet", "Cadre", 2000, new DateTime(2011, 05, 05).Date, "il fait beau");
            //Console.WriteLine(contrat.ToString());

            //collaborateur.AddContrat(contrat);


            //Cdi contrat2 = new Cdi(new DateTime(2010, 5, 5).Date, "Chef de Projet", "Cadre", 5000);
            //collaborateur.AddContrat(contrat2);

            //listeCollaborateurs.AddNewCollaborateur(collaborateur);
            //collaborateur = new Collaborateur("F", "DUPONt", "Rogee", "CELIBATAIRE", true);
            //contrat2 = new Cdi(new DateTime(2012, 6, 6).Date, "CDI", "employee", 1500);

            //collaborateur.AddContrat(contrat);
            //listeCollaborateurs.AddNewCollaborateur(collaborateur);
        }




    }
}
