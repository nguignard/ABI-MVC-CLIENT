using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{

    /// <summary>
    /// ctrlVisuContrat, Classe controlleur gerant le form de visualisation des contrats
    /// </summary>
    class ctrlVisuContrat
    {
        frmVisuContrat leForm;
        ContratType leContrat;


        /// <summary>
        /// Constructeur ctrlVisuContrat:
        /// - lance le form de visualisation
        /// gere l'evenement de 
        /// </summary>
        /// <param name="unContrat"></param>
        public ctrlVisuContrat(ContratType unContrat)
        {
            this.leContrat = unContrat;
            this.leForm = new frmVisuContrat(leContrat);

            this.leForm.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);

            this.leForm.Show();
            this.leForm.AfficheContrat(unContrat);



        }

       

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            //TODO

        }






    }
}
