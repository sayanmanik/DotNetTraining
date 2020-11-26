using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] locations = {
            "Kolkata",
            "Bengaluru",
            "BBSR",
            "HYD"
            };

            var result = from city in locations
                         group city
                         by city.Substring(0, 1)
                         into cityGroup
                         orderby cityGroup.Key
                         select cityGroup;

           foreach(var place1 in result)
            {
                Console.WriteLine(place1.Key);
                foreach (var place2 in place1)
                {
                    Console.WriteLine(" "+place2);
                }
                Console.WriteLine();
            }
        }
    }
}
