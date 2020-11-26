using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingDemo
{
    class ProductDemo
    {
        object objProductId;
        object objProductName;
        object objPrice;
        object objQuantity;
        double amountPayable;

        public ProductDemo(int objProductId, string objProductName, int objPrice, int objQuantity)
        {
            this.objProductId = objProductId;
            this.objProductName = objProductName;
            this.objPrice = objPrice;
            this.objQuantity = objQuantity;
        }



        public void calculate()
        {
            amountPayable = (int)objQuantity * (int)objPrice; 
        }


        public void display()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("Product ID: "+(int)objProductId);
            Console.WriteLine("Product Name: "+(string)objProductName);
            Console.WriteLine("Price: "+(int) objPrice);
            Console.WriteLine("Quantity: "+objQuantity);
            Console.WriteLine("Amt Payable: "+ String.Format("{0:0.00}", amountPayable));
        }
    }
}
