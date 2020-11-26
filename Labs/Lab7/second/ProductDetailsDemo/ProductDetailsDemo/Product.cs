using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetailsDemo
{
    class Product
    {
        int productNo;
        string name;
        double rate;
        int stock;

        public Product(int productNo, string name, double rate, int stock)
        {
            this.productNo = productNo;
            this.name = name;
            this.rate = rate;
            this.stock = stock;
        }

        public int ProductNo
        {
            get
            {
                return productNo;
            }

            set
            {
                productNo = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        } 

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }
            
        
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }


    }
}
