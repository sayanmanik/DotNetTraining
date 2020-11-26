using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetailsDemo
{
   
    class Program
    { 
        
        static List<Product> list;
        static int index;
        static void Main(string[] args)
        {
            list = new List<Product>();

            for (int i=0;i<2;i++)
            {
                AddProduct();
            }

            SearchByProductNo();
            DeleteProduct();
            Console.WriteLine("Before sorting");
            DisplayProducts();
            list = SortBasedOnProductNo();
            Console.WriteLine("After sorting");
            DisplayProducts();
        }


        static void AddProduct()
        {
            Console.WriteLine("Enter a new product");

            Console.WriteLine("Enter name ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter product No");
            int no = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter rate");
            double rate = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter stock");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product p = new Product(no,name,rate,stock);

            list.Add(p);
        }


        static void SearchByProductNo()
        {
            Console.WriteLine("Enter product number");
            int productNo = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].ProductNo == productNo)
                {
                    flag = 1;
                    index = i;
                    Console.WriteLine("Product no:{0}, Product Name:{1}, Product rate:{2}, Product stock:{3}",list[i].ProductNo,list[i].Name,list[i].Rate,list[i].Stock);
                }

            }

            if (flag == 0)
            {
                Console.WriteLine("Not found");
            }
        }


        static void DeleteProduct()
        {
            Console.WriteLine("Delete By Index");
           
            list.RemoveAt(index);
        }

        static void DisplayProducts()
        {
            for (int k=0;k<list.Count;k++)
            {
                Console.WriteLine("Product no:{0}, Product Name:{1}, Product rate:{2}, Product stock:{3}", list[k].ProductNo, list[k].Name, list[k].Rate, list[k].Stock);
            }
        }

        static List<Product> SortBasedOnProductNo()
        {
            var newList = list.OrderBy(o => o.ProductNo).ToList();
            return newList;
        }
    }
}
