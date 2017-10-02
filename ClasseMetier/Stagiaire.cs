/***********************************************************************
 * Module:  Stagiaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stagiaire
 ***********************************************************************/

using System;
using System.Runtime.Serialization;


namespace ABIEnCouches
{

    /// <summary>
    /// Classe Stagiaire, heritee de ContratTemporaire
    /// </summary>
    /// 
    [DataContract]
    [Serializable]
    public class Stagiaire : ContratTemporaire
    {
        private String ecole;
        private String mission;


        /// <summary>
        /// Constructeur de Stagiaire
        /// </summary>
        /// <param name="idContrat"></param>
        /// <param name="ecole"></param>
        /// <param name="mission"></param>
        /// <param name="motif"></param>
        /// <param name="dateDebutContrat"></param>
        /// <param name="datFinContrat"></param>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireContractuel"></param>
        public Stagiaire(int idContrat, String ecole, String mission, 
            String motif, DateTime dateDebutContrat, DateTime datFinContrat, String qualification, String statut,  Decimal salaireContractuel) : 
            base( idContrat,  dateDebutContrat,  qualification,  statut,  salaireContractuel,  datFinContrat,  motif)
        {
            this.ecole = Ecole;
            this.Mission = Mission;
        }

        /// <summary>
        /// to string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
           
            return "Stage : Ecole " + Ecole+ " Mission " + Mission;
        }

        /// <summary>
        /// GETSET Ecole
        /// </summary>
        /// 
        [DataMember]
        public String Ecole
        {
            get
            {
                return ecole;
            }
            set
            {
                if (this.ecole != value)
                    this.ecole = value;
            }
        }

        /// <summary>
        /// GETSET Mission
        /// </summary>
        /// [DataMember]
        /// 
        [DataMember]
        public String Mission
        {
            get
            {
                return mission;
            }
            set
            {
                if (this.mission != value)
                    this.mission = value;
            }
        }

    }
}