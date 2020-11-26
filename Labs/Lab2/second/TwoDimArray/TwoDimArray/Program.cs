using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[5][];
            
            for(int i = 0; i < 5; i++)
            {
                array[i] = new int[6];
            }

            Console.WriteLine("Enter the values");

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Result: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
