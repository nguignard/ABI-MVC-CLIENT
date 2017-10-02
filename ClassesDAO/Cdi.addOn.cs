using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe de Cdi Entity
    /// </summary>
    public partial class CdiE
    {

        /// <summary>
        /// Constructeur vide d'un Cdi Entity
        /// </summary>
        public CdiE()
        {
        }
        /// <summary>
        /// Constructeur d'un CDI Entity FrameWork
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="dateFinReelle"></param>
        public CdiE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle)
                :base(  idContrat,            dateDebutContrat,       qualification,        statut,           salaireContractuel, dateFinReelle)
        {
        }

    }
}
