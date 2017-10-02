using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe collaborateur Entity FrameWork
    /// </summary>
    public partial class CollaborateursE
    {

        /// <summary>
        /// Constructeur complet de collaborateur Entity FrameWork
        /// </summary>
        /// <param name="matriculeE"></param>
        /// <param name="civiliteE"></param>
        /// <param name="nomE"></param>
        /// <param name="prenomE"></param>
        /// <param name="situationE"></param>
        /// <param name="photoE"></param>
        /// <param name="actifE"></param>
        public CollaborateursE(int matriculeE, string civiliteE, string nomE, string prenomE, string situationE, string photoE, bool actifE)
        {
            this.matriculeE = matriculeE;
            this.civiliteE = civiliteE;
            this.nomE = nomE;
            this.prenomE = prenomE;
            this.situationE = situationE;
            this.photoE = photoE;
            this.actifE = actifE;

            this.ContratTypeE = new HashSet<ContratTypeE>();
        }
    }
}
