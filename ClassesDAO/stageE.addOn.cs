using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe Stage gerant les constructeurs de stages Entity
    /// </summary>
    public partial class StageE : ContratTemporaireE
    {
        /// <summary>
        /// constructeurs vide de stages Entity
        /// </summary>
        public StageE()
        {
        }

        /// <summary>
        /// constructeurs vide de stages Entity
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="dateFinReelle"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        /// <param name="ecole"></param>
        /// <param name="mission"></param>
        public StageE(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel, DateTime? dateFinReelle,
            DateTime dateFin, string motif,
            string ecole, string mission)
        {
            this.ecoleE = ecole;
            this.missionE = mission;


        }

    }
}
