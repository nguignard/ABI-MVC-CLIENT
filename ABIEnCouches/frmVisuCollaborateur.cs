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
    /// class frmVisuCollaborateur permet de visualiser un collabotrateur
    /// </summary>
    public partial class frmVisuCollaborateur : Form
    {
        Collaborateur leCollaborateur;


        /// <summary>
        /// constructeur frmVisuCollaborateur
        /// </summary>
        /// <param name="unCollab"></param>
        public frmVisuCollaborateur(Collaborateur unCollab)
        {
            this.leCollaborateur = unCollab;
            InitializeComponent();
        }


        internal void AfficheCollaborateur(Collaborateur unCollab)
        {
            this.Text = unCollab.ToString();
            this.txtNumeroMatricule.Text = unCollab.Matricule.ToString();
            this.txtNom.Text = unCollab.NomCollab;
            this.txtPrenom.Text = unCollab.PrenomCollab;
            this.rdbM.Checked = unCollab.Civilite == "M" ? true : false;
            this.rdbF.Checked = unCollab.Civilite == "F" ? true : false;
            this.cmbFamille.Text = unCollab.SituationFamiliale;

            this.grdContrats.DataSource = unCollab.ListerContrats();
            this.grdContrats.Refresh();
            this.btnFermer.Enabled = true;
        }


        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();

            //DialogResult dialogResult = MessageBox.Show("Voulez vous fermer la fenêtre, Yes pour confirmer", "Fermeture", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    this.Close();
            //}
        }

    }
}
