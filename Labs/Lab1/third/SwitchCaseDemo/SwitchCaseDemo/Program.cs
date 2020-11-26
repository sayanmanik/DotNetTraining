using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("1 printed");
                    break;
                case 2:
                    Console.WriteLine("2 printed");
                    break;
                case 3:
                    Console.WriteLine("3 printed");
                    break;
                case 4:
                    Console.WriteLine("4 printed");
                    break;
                case 5:
                    Console.WriteLine("5 printed");
                    break;
                default:
                    Console.WriteLine("Out of limit");
                    break;


            }
        }
    }
}
