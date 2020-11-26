using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameerHashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable hashtable = GetHashtable();
            Console.WriteLine(hashtable.ContainsKey("Perimeter"));
            Console.WriteLine(hashtable.Contains("Perimeter"));


            hashtable.Remove("Mortgage");
            Console.WriteLine(hashtable["Area"]);
        }


        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
    }
}
