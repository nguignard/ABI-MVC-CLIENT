/***********************************************************************
 * Module:  Avenant.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Avenant
 ***********************************************************************/

using System;



namespace ABIEnCouches
{
    /// <summary>
    /// classe ABIEnCouches
    /// </summary>
    public class Avenant
    {

        //ATTRIBUTS------------------------------------
        private int idAvenant;
        private String contenu;
        
        //CONSTRUCTEURS---------------------------------------

        /// <summary>
        /// Avenant(int idAvenant,string contenu)
        /// </summary>
        /// <param name="idAvenant"></param>
        /// <param name="contenu"></param>
        public Avenant(string contenu)
        {
            IdAvenant = Donnees.CompteurAvenant++;
        }

        //PROPRIETES-----------------------------------------

        /// <summary>
        /// PPT idAvenant
        /// </summary>
        public int IdAvenant
        {
            get
            {
                return idAvenant;
            }

            private set
            {
                if ((this.idAvenant > 0))
                {
                    idAvenant = value;
                }
                else
                {
                    throw new Exception("Avenant id <=0");
                }
            }
        }

        public string Contenu
        {
            get
            {
                return contenu;
            }

            set
            {
                contenu = value;
            }
        }




        public override string ToString()
        {
          
            return "idAvenant "+ IdAvenant + " contenu "+ Contenu;
        }



    }
}