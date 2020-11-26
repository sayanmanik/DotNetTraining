using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{

    struct ArithmeticOperation
    {
        public int number;

        public int SquareNumber()
        {
            return number * number;
        }  

        public int CubeNumber()
        {
            return number * number * number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ArithmeticOperation operation = new ArithmeticOperation();
            Console.WriteLine("Enter number");
            operation.number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1 for square and 2 for cube");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Square of {0} is {1} ", operation.number, operation.SquareNumber());
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Square of {0} is {1} ", operation.number, operation.CubeNumber());
                    Console.ReadLine();
                    break;
            }

            




        }
    }
}
