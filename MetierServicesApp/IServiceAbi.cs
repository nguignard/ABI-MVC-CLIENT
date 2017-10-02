using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIEnCouches;


namespace MetierServicesApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceAbi" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceAbi
    {
        /// <summary>
        /// Pour test
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        string GetData(int value);


        [OperationContract]
        IList<Collaborateur> GetCollaborateurs();


        [OperationContract]
        string addCollaborateur(Collaborateur newCollaborateur);


        [OperationContract]
        IList<ContratType> GetContratsCollaborateur(string matricule);




        //NOT IMPLEMENTED---------------------------------------------------------


        //[OperationContract]
        //string UpdateCollaborateur(Collaborateur newCollaborateur);



        //[OperationContract]
        //string AddContratCollaborateur(Collaborateur unCollaborateur, ContratType unNouveauContrat);



    }


}
