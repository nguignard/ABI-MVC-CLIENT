using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    /// <summary>
    /// Classe Collaborateur : controleur du form permettant d'ajouter un collaborateur
    /// </summary>
    class ctrlAjouterCollaborateur
    {
        private frmAjouterCollab leForm;

        private Collaborateur leCollaborateur;
        private ContratType leContrat;
        private DialogResult result;


        /// <summary>
        /// constructeur vide,evenement ajouter une photo, valide le form d'un nouveau collaborateur
        /// </summary>
        public ctrlAjouterCollaborateur()
        {
            leForm = new frmAjouterCollab();
           
            this.leForm.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click);
            this.leForm.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            this.leForm.ShowDialog();
        }

        //GET SUR VARIABLE A ENTRER DANS LES COLLECTIONS
        public Collaborateur LeCollaborateur
        {
            get
            {
                return leCollaborateur;
            }
        }
        
        public DialogResult Result
        {
            get
            {
                return result;
            }
        }

        //FONCTIONS-------------------------------------------------------------

        /// <summary>
        /// btnValider_Click affiche une boite de controle validant l'ajout d'un nouveau collaborateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.leForm.Controle())
            {
                if (this.leForm.InstancieCollaborateur())
                {
                    this.leForm.DialogResult = DialogResult.OK;
                    this.result = DialogResult.OK;
                    this.leCollaborateur = this.leForm.NewCollaborateur;

                    leForm.Close();

                }
                else
                {
                    this.result = DialogResult.No;
                }
            }
        }

        /// <summary>
        /// btnAjouterPhoto_Click ajoute une photo, non géré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPhoto_Click(object sender, EventArgs e)
        {
            //TODO
        }





    }
}
