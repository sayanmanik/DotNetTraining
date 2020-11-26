using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            AddRecord(hashtable);

            Console.WriteLine("Elements before deletion");
            DisplayRecords(hashtable);
            
            Console.WriteLine("Total Count Before Deletion: "+hashtable.Count);

            SearchRecord(hashtable);

            DeleteRecord(hashtable);

            Console.WriteLine("Total Count After Deletion: " + hashtable.Count);

            Console.WriteLine("Elements after deletion");
            DisplayRecords(hashtable);
        }

        private static void DeleteRecord(Hashtable hashtable)
        {
            Console.WriteLine("Search a key to delete");
            string key = Console.ReadLine();

            if (hashtable.ContainsKey(key))
            {
                hashtable.Remove(key);
            }
            else
            {
                Console.WriteLine("No such key");
            }
        }

        private static void SearchRecord(Hashtable hashtable)
        {
             Console.WriteLine("Search by Key");
             string key = Console.ReadLine();

            if (hashtable.ContainsKey(key))
            {
                Console.WriteLine(key+","+hashtable[key]);
            }
            else
            {
                Console.WriteLine("No such key");
            }
             
        }



        private static void AddRecord(Hashtable hashtable)
        {
            hashtable.Add("WB-01", "Kolkata");
            hashtable.Add("WB-05", "Kasaba");
            hashtable.Add("WB-07", "Salt Lake");
            hashtable.Add("WB-09", "Behala");
            hashtable.Add("WB-11", "Howrah");
        }


        private static void DisplayRecords(Hashtable hashtable)
        {
            foreach(string key in hashtable.Keys)
            {
                Console.WriteLine(key +","+hashtable[key]);
            }
        }

    }
}
