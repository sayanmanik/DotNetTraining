using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMockEntityException
{
    class ProductMock
    {
        private int productId;
        private string productName;
        private double price;


        public ProductMock(int productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
}
