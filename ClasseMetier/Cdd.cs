/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;
using System.Runtime.Serialization;



namespace ABIEnCouches
{
    /// <summary>
    /// Classe Metier ContratTemporaire abstraite
    /// </summary>
    [Serializable]
    
    public class Cdd : ContratTemporaire
    {
        /// <summary>
        /// Constructeur d'un CDD
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        /// <param name="datFinContrat"></param>
        /// <param name="motif"></param>
        public Cdd(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel,
            DateTime datFinContrat, String motif): base(idContrat, dateDebutContrat,  qualification,  statut,  salaireContractuel, 
                datFinContrat,  motif)
        {
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "CDD : dateDebutContrat "+ dateDebutContrat+ " idContrat " + idContrat + " datFinContrat " + dateFinContrat;
        }

    }
}