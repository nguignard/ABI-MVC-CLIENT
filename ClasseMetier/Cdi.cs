/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;
using System.Runtime.Serialization;


namespace ABIEnCouches
{
    /// <summary>
    /// Classe Metier Cdi
    /// </summary>
    /// 
    [DataContract]
    public class Cdi : ContratType
    {

        public Cdi(int idContrat, DateTime dateDebutContrat, String qualification, String statut, Decimal salaireContractuel)
            :base(      idContrat,          dateDebutContrat,       qualification,          statut,         salaireContractuel)
        {       
        }


        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "CDI : idContrat " + idContrat + " dateDebutContrat " + dateDebutContrat + " salaireContractuel " + salaireContractuel;
        }

    }
}