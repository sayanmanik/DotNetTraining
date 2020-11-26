using System;
using System.Security.Cryptography.X509Certificates;

namespace Day2
{
    class Methods
    {

        static void swap_out(out int x, out int y)
        {
            x = 10;
            y = 20;
        }


        static void swap_ref(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;

        }

        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello World!");

            int x=1, y=2;
            Console.WriteLine("x is {0} and y is {1}",x,y);

            int a, b;
            swap_out(out a, out b);
            Console.WriteLine("a is {0} and b is {1}", a, b);

            swap_ref(ref a, ref b);
            Console.WriteLine("a is {0} and b is {1}", a, b);

     




        }
    }
}
