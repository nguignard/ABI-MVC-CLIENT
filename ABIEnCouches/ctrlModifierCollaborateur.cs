using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEnCouches
{

    /// <summary>
    /// classe ctrlModifierCollaborateur: controle le form qui affiche un collaborateur pour modification 
    /// </summary>
    class ctrlModifierCollaborateur
    {
        Collaborateur leCollaborateur;
        frmModifierCollaborateur frmModifierCollab;


        /// <summary>
        /// Constructeur ctrlModifierCollaborateur controle le form qui affiche un collaborateur pour modification
        /// </summary>
        /// <param name="unCollaborateur"></param>
        public ctrlModifierCollaborateur(Collaborateur unCollaborateur)
        {
            this.leCollaborateur = unCollaborateur;
            frmModifierCollab = new frmModifierCollaborateur(this.leCollaborateur);
            this.frmModifierCollab.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            frmModifierCollab.Show();
        }

        /// <summary>
        /// btnValider_Click controle la validation du collaborateur modifie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {


            this.frmModifierCollab.modifieCollaborateur();

            this.frmModifierCollab.Close();







        }

    }
}
