using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{

    /// <summary>
    /// Classe abstraite complementaire de Contrat temporaire EntityFrameWork
    /// </summary>
    public partial class ContratTemporaireE : ContratTypeE
    {

        /// <summary>
        /// Constructeur vide de Contrat temporaire EntityFrameWork
        /// </summary>
        public ContratTemporaireE()
        {
        }
        /// <summary>
        /// Constructeur complet de de Contrat temporaire EntityFrameWork
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="dateFinReelle"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public ContratTemporaireE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle,
            DateTime dateFin, string motif)
            :base( idContrat,  dateDebutContrat,  qualification,  statut,  salaireContractuel, dateFinReelle)
        {
            this.dateFinE = dateFin;
            this.motifE = motif;
        }

    }
}
