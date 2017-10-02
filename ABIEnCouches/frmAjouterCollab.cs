using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{

    /// <summary>
    /// classe frmAjouterCollab
    /// </summary>
    public partial class frmAjouterCollab : Form
    {
        private Collaborateur newCollaborateur;
        private ContratType newContrat;


        /// <summary>
        /// Constructeur frmAjouterCollab affiche un collaborateur champ blanc
        /// </summary>
        public frmAjouterCollab()
        {
            InitializeComponent();
            this.Text = "Nouveau Collaborateur";
            this.whiteCollaborateur();
            this.AfficheWindowContrat();
        }


        //GET NEW------------------------------------------------
        /// <summary>
        /// NewCollaborateur : Getter
        /// </summary>
        public Collaborateur NewCollaborateur
        {
            get
            {
                return this.newCollaborateur;
            }
        }



        //INSTANCIATION DU NOUVEAU COLLABORATEUR--------------------------
        /// <summary>
        /// InstancieCollaborateur methode instanciant un collaborateutr et son contrat initial 
        /// </summary>
        /// <returns></returns>
        internal bool InstancieCollaborateur()
        {
            try
            {
                string sexe = "F";
                if (this.rdbM.Checked)
                {
                    sexe = "M";
                }

                newCollaborateur = new Collaborateur(   sexe,
                                                        this.txtNom.Text,
                                                        this.txtPrenom.Text,
                                                        this.cmbFamille.SelectedItem.ToString(),
                                                        true);

                this.instancieContrat();
                this.newCollaborateur.AddContrat(newContrat);
                

                return true;
            }
            catch (Exception ex)
            {
                newCollaborateur = null;
                newContrat = null;
                ex.Message.ToString();
                return false;
            
            }

        


            
        }

        /// <summary>
        /// instancieContrat() devra être placer dans frmNewContrat
        /// </summary>
        /// <returns></returns>
        internal void instancieContrat()
        {
                if (this.rdbCDI.Checked)
                {
                    newContrat = new Cdi(1,
                        this.dateDebut.Value.Date,
                        this.txtQualif.Text,
                        this.txtStatut.Text,
                        Convert.ToDecimal(this.txtSalaire.Text)
                      );

                }
                else if (this.rdbCDD.Checked)
                {
                    newContrat = new Cdd(1,
                     this.dateDebut.Value.Date,
                     this.txtQualif.Text,
                     this.txtStatut.Text,
                     Convert.ToDecimal(this.txtSalaire.Text),
                     this.dateFin.Value.Date,
                     this.txtMotif.Text
                   );

                }
                else
                {
                    newContrat = new Stagiaire(1,
                      this.txtEcole.Text,
                      this.txtMission.Text,
                       this.txtMotif.Text,
                      this.dateDebut.Value.Date,
                      this.dateFin.Value.Date,
                      this.txtQualif.Text,
                      this.txtStatut.Text,
                      Convert.ToDecimal(this.txtSalaire.Text)
                    );

                //return newContrat;

                }
        }


        /// <summary>
        ///  non instancié
        /// </summary>
        /// <returns></returns>
        internal Boolean Controle()
        { return true; }




        /// <summary>
        /// btnCancel_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous réinitialiser les champs, Yes pour confirmer", "Réinitialisation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.whiteCollaborateur();
                this.AfficheWindowContrat();
            }
        }

        /// <summary>
        /// btnFermer_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous fermer la fenêtre, Yes pour confirmer", "Fermeture", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // GESTION DE L'AFFICHAGE DE CHAMPS DE CONTRAT----------------------------------------------------------
     
        /// <summary>
        /// rdbCDI_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCDI_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheWindowContrat();
        }

        /// <summary>
        /// rdbCDD_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCDD_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheWindowContrat();
        }


    /// <summary>
    /// rdbStage_CheckedChanged
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void rdbStage_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheWindowContrat();
        }


        //FONCTIONS-----------------------------------

            /// <summary>
            /// Affiche a blanc un contrat
            /// </summary>
        internal void WhiteContrat()
        {
            this.txtEcole.Text = "";
            this.txtMission.Text = "";
            this.txtMotif.Text = "";
            this.txtQualif.Text = "";
            this.txtSalaire.Text = "";
            this.txtStatut.Text = "";
            this.rdbCDI.Checked = true;
        }

    /// <summary>
    /// whiteForm() réinitialise le collaborateur en blanc
    /// </summary>
    internal void whiteCollaborateur()
    {
        this.txtNom.Text = "";
        this.txtPrenom.Text = "";
        this.cmbFamille.Items.Clear();
        this.cmbFamille.Items.AddRange(new String[] { "CELIBATAIRE", "MARIE", "DIVORCE" });
        this.cmbFamille.SelectedIndex = this.cmbFamille.FindString("CELIBATAIRE");
        this.rdbM.Checked = true;

        this.WhiteContrat();
    }


        /// <summary>
        /// AfficheBoxContrat() gere les accessibilités des composants du form en fonction du type de contrat
        /// </summary>
        private void AfficheWindowContrat()
        {
            //this.lblDateFin.Enabled = false;
            //this.lblCivilite.Enabled = true;
            //this.lblDateDebut.Enabled = true;
            //this.lblNom.Enabled = true;
            //this.lblPrenom.Enabled = true;
            //this.lblQualification.Enabled = true;
            //this.lblSalaire.Enabled = true;
            //this.lblSituation.Enabled = true;
            //this.lblStatut.Enabled = true;
            //this.lblEcole.Enabled = true;
            //this.lblMission.Enabled = true;



            this.dateFin.Enabled = true;
            this.txtMotif.Enabled = true;
            this.lblMotif.Enabled = true;
            this.grpStage.Enabled = true;

            if (this.rdbCDI.Checked == true)
            {
                this.dateFin.Enabled = false;
                this.txtMotif.Enabled = false;
                this.lblMotif.Enabled = false;
                this.grpStage.Enabled = false;
            }

            if (this.rdbCDD.Checked == true)
            {
                this.grpStage.Enabled = false;
            }
        }



    }
}
