using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number=255;
            // var x = 12;
            // Console.WriteLine(number);



            //string s = "1";
            //int i = Convert.ToInt32(s);
            //int j = int.Parse(s);

            //Console.WriteLine(i);
            //Console.WriteLine(j);

            Console.WriteLine("Multi valued array");
            Console.WriteLine("Enter values: ");
            int[,] x = new int[2,2];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Sayan");




            Console.WriteLine("Jagged array");
            Console.WriteLine("Enter values: ");
            int[][] y = new int[2][];

            y[0] = new int[] { 2, 4, 5 };
            y[1] = new int[] { 1, 2 };

            //for (int i = 0; i < x.GetLength(0); i++)
            //{
            //    for (int j = 0; j < x.GetLength(1); j++)
            //    {
            //        x[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    Console.Write(y[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
