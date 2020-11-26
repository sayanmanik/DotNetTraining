using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShoppingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<ShoppingItem> shoppingList = new List<ShoppingItem>();
        public bool AdditemToCart(ShoppingItem item)
        {
            if (item != null)
            {
                shoppingList.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoveItemToCart(int id)
        {

            ShoppingItem temp = shoppingList.Find(s => s.ID == id);
            if (temp != null)
            {
                shoppingList.Remove(temp);
                return true;
            }
            return false;
        }

        public List<ShoppingItem> ShowAllItems()
        {
            return shoppingList;
        }
    }
}
