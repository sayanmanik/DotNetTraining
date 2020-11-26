using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {

        static void display(ArrayList al)
        {
            foreach (var val in al)
            {
                Console.WriteLine(val+","+val.GetType());
            }
        }

        static void displayHash(SortedList ht)
        {
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //Console.WriteLine(al.Capacity);

            //al.Add(100);
            //al.Add("John");
            //al.Add(true);
            //al.Add('S');
            //al.Add(22.00f);

            //Console.WriteLine(al.Capacity);

            //al.Remove(100);

            //display(al);

            //StringCollection col = new StringCollection();
            //col.Add("A");
            //col.Add("B");
            //col.Add("C");


            //foreach (string s in col)
            //{
            //    Console.WriteLine(s);
            //}


            ////Hashtable ht = new Hashtable();
            //SortedList ht = new SortedList();
            //ht.Add("PNQ","Pune");
            //ht.Add("BOM","Mumbai");
            //ht.Add("HYD","Hyderabad");

            //displayHash(ht);

            //ht.Remove("PNQ");
            //displayHash(ht);


            //Console.WriteLine(ht.ContainsValue("Chennai"));


            //Stack stack = new Stack();
            //stack.Push(100);
            //stack.Push("Sayan");
            //stack.Push(35000.00);

            //foreach (var ele in stack)
            //{
            //    Console.WriteLine(ele);
            //}





            ProductCollection products = new ProductCollection();
            products.Add(new Product { Id = 1, Name = "TV", UnitPrice=200.00 });
            products.Add(new Product { Id = 2, Name = "Phone", UnitPrice = 500.00 });
            products.Add(new Product { Id = 3, Name = "Laptop", UnitPrice = 600.00 });

            foreach(Product p in products)
            {
                Console.WriteLine("{0},{1},{2}",p.Id,p.Name,p.UnitPrice);
            }

            products.RemoveAt(0);

            foreach (Product p in products)
            {
                Console.WriteLine("{0},{1},{2}", p.Id, p.Name, p.UnitPrice);
            }
        }
    }
}
