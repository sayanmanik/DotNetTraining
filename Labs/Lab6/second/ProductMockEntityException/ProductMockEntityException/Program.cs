using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMockEntityException
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter product id");
            int id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter price");
            double price = Convert.ToDouble(Console.ReadLine());


           

            if (id <= 0)
            {
                throw new DataEntryException("Product Id must be greater than zero");
            }

            if (name == "")
            {
                throw new DataEntryException("Product Name must not be blank");
            }


            if (price <= 0)
            {
                throw new DataEntryException("Product price must be greater than zero");
            }


            ProductMock product = new ProductMock(id,name,price);

            Console.WriteLine("Id {0}, Name {1}, price {2} ", product.ProductId, product.ProductName,product.Price);
        }
    }
}
