using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{

    /// <summary>
    /// CLASSE DE FONCTIONS OUTILS UTILISEE PAR PLUSIEURS CLASSES DE VISUALISATION
    /// </summary>
    public static class Outils
    {

        /// <summary>
        /// WhiteContrat Methode remettant les champs d'un collaborateur a blanc
        /// </summary>
        /// <param name="leForm"></param>
        public static void WhiteContrat(frmAjouterCollab leForm)
        {
                leForm.txtEcole.Text = "";
                leForm.txtMission.Text = "";
                leForm.txtMotif.Text = "";
                leForm.txtQualif.Text = "";
                leForm.txtSalaire.Text = "";
                leForm.txtStatut.Text = "";
                leForm.rdbCDI.Checked = true;
        }



        



    }
}
