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
    /// classe frmListCollab : affiche la liste des collaborateurs
    /// </summary>
    public partial class frmListCollab : Form
    {
        private Collaborateurs listeCollaborateurs;


        /// <summary>
        /// constructeur frmListCollab 
        /// </summary>
        /// <param name="uneliste"></param>
        public frmListCollab(Collaborateurs uneliste)
        {
            InitializeComponent();
            this.listeCollaborateurs = uneliste;
        }


        /// <summary>
        /// affiche le data grid de la liste de collaborateurs
        /// </summaafficheCollaborateursry>
        /// <param name="listeCollaborateurs"></param>
        internal void afficheCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            this.grdCollaborateurs.DataSource = listeCollaborateurs.ListerCollaborateurs();
            this.grdCollaborateurs.Refresh();
            this.btnFermer.Enabled = true;
        }

        /// <summary>
        /// btnFermer_Click ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// LeveErreur affiche un message dans la fenêtre principal ( exceptions...)
        /// </summary>
        /// <param name="ex"></param>
        internal void LeveErreur(Exception ex)
        {
            this.lblErreur.Text =  ex.Message;
        }
    }
}
