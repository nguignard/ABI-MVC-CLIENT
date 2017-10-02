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
    /// classe frmModifierCollaborateur affiche un collaborateur pour modification et instancie le collaborateur modifie
    /// </summary>
    public partial class frmModifierCollaborateur : Form
    {

        Collaborateur oldCollaborateur;


        /// <summary>
        /// Constructeur frmModifierCollaborateur: Affiche le collaborateur a modifier
        /// </summary>
        /// <param name="unCollaborateur"></param>
        public frmModifierCollaborateur(Collaborateur unCollaborateur)
        {
            this.oldCollaborateur = unCollaborateur;
            InitializeComponent();
            this.AfficheCollaborateur(oldCollaborateur);
        }


        /// <summary>
        /// Fonction affichant le collaborateur à son état avant modification
        /// </summary>
        /// <param name="unCollab"></param>
        internal void AfficheCollaborateur(Collaborateur unCollab)
        {
            this.Text = unCollab.ToString();
            this.txtNumeroMatricule.Text = unCollab.Matricule.ToString();
            this.txtNom.Text = unCollab.NomCollab;
            this.txtPrenom.Text = unCollab.PrenomCollab;
            this.rdbM.Checked = unCollab.Civilite == "M" ? true : false;
            this.rdbF.Checked = unCollab.Civilite == "F" ? true : false;
            this.cmbFamille.Text = unCollab.SituationFamiliale;
            this.btnFermer.Enabled = true;
        }


        /// <summary>
        /// modifieCollaborateur instancie le nouveau collaborateur
        /// </summary>
        internal void modifieCollaborateur()
        {
            try
            {
                Collaborateur newCollab = new Collaborateur((this.rdbM.Checked ? "M" : "F"), this.txtNom.Text, this.txtPrenom.Text, this.cmbFamille.Text.ToString(), true);
                //newCollab.Matricule = oldCollaborateur.Matricule;
            }
            catch (Exception)
            {
                throw new Exception("le Collaborateur n'a pu être modifier, une valeur est inexacte");
            }

            
            //TODO
        }



        /// <summary>
        /// btnFermer_Click ferme la fenetre de modif collaborateur sans changement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment Fermer sans changement, Yes pour confirmer", "Fermer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// btnAnnuler_Click remets les champs d'un collaborateurs tels qu'ils etaient au debut 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous réinitialiser les champs, Yes pour confirmer", "Réinitialisation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.AfficheCollaborateur(oldCollaborateur);
            }
        }

    }
}
