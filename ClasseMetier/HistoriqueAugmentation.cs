/***********************************************************************
 * Module:  HistoriqueAugmentation.cs
 * Author:  CDI14
 * Purpose: Definition of the Class HistoriqueAugmentation
 ***********************************************************************/

using System;



namespace ABIEnCouches
{

    /// <summary>
    /// Classe NON IMPLEMENTEE
    /// </summary>
    public class HistoriqueAugmentation
    {

       //ATTRIBUTS----------------------------------------------------------------

        private Decimal montantAugmentation;
        private DateTime dateAugmentation;


        //CONSTRUCTEURS----------------------------------------------------------------


        /// <summary>
        /// Constructeur HistoriqueAugmentation
        /// </summary>
        /// <param name="dateAugmentation"></param>
        /// <param name="montantAugmentation"></param>
        HistoriqueAugmentation(DateTime dateDernièreAugmentation, DateTime dateNouvelleAugmentation, Decimal montantAugmentation)
        {
            this.DateAugmentation = dateAugmentation;
            this.MontantAugmentation = montantAugmentation;
        }




        //ACCESSEUR --------------------------------------------------------------------

        /// <summary>
        /// accesseur MontantAugmentation
        /// </summary>
        public Decimal MontantAugmentation
        {
            get
            {
                return montantAugmentation;
            }
            set
            {
                if (this.montantAugmentation < 0)
                {
                    throw new Exception("l'augmentation doit être > 0");
                }
                else { 
                    this.montantAugmentation = value;
                }
            }
        }



        /// <summary>
        /// ACCESSEUR DateAugmentation
        /// </summary>
        public DateTime DateAugmentation
        {
            get
            {
                return dateAugmentation;
            }
            set
            {
                this.dateAugmentation = value;
            }
        }




        // FONCTIONS-------------------------------------------------------------

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "dateAugmentation "+ dateAugmentation+ " montantAugmentation " + montantAugmentation;
        }



    }
}