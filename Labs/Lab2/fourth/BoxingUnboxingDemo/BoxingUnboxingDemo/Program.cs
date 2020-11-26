using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the id of product:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of product:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter price:");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity:");
            int qty = Convert.ToInt32(Console.ReadLine());

            ProductDemo product = new ProductDemo(id,name,price,qty);
            product.calculate();
            product.display();

        }
    }
}
