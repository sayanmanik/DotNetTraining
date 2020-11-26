using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShoppingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool AdditemToCart(ShoppingItem item);


        [OperationContract]
        bool RemoveItemToCart(int id);


        [OperationContract]
        List<ShoppingItem> ShowAllItems();
 














        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ShoppingItem
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public double ItemPrice { get; set; }


    }
}
