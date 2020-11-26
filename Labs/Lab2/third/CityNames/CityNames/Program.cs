using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[5];

            Console.WriteLine("Enter the names of the cities");
            for (int i=0;i<cities.Length;i++)
            {
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("Cities are");
            foreach(string city in cities)
            {
                Console.WriteLine(city+" ");
            }
        }
    }
}
