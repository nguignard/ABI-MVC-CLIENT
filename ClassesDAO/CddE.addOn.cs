using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{

    /// <summary>
    /// Classe Entity d'un Cdd
    /// </summary>
    public partial class CddE:ContratTemporaireE
    {

        /// <summary>
        /// Constructeur vide de CDD pour Entity framework
        /// </summary>
        public CddE()
        {
        }
        /// <summary>
        /// Constructeur de CDD complet
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="dateFinReelle"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public CddE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle,
            DateTime dateFin, string motif  ): base( idContrat,  dateDebutContrat,  qualification,  statut,  salaireContractuel,   dateFinReelle,
             dateFin,  motif)
        {
        }



    }
}
