using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe abstraite de Contrat type Entity FrameWork
    /// </summary>
    public partial class ContratTypeE
    {
        /// <summary>
        /// 
        /// 
        /// onstructeur vide de  Contrat type Entity FrameWork
        /// </summary>
        public ContratTypeE()
        {
        }

        /// <summary>
        ///  Constructeur complet de Contrat type Entity FrameWork
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="dateFinReelle"></param>
        public ContratTypeE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle)
        {
            this.idContratE = idContrat;
            this.dateDebutE = dateDebutContrat;
            this.qualificationE = qualification;
            this.statutE = statut;
            this.salaireE = salaireContractuel;
            this.finReelleE = dateFinReelle;
    }

    }
}
