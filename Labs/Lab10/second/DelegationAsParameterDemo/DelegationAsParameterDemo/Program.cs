using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationAsParameterDemo
{
    class Program
    {

        delegate int DelegateArithmetic(int x,int y);
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 1st number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            DelegateArithmetic de1 = new DelegateArithmetic(Addition);

            DelegateArithmetic de2 = new DelegateArithmetic(Subtraction);

            DelegateArithmetic de3 = new DelegateArithmetic(Multiplication);

            DelegateArithmetic de4 = new DelegateArithmetic(Division);

            DelegateArithmetic de;

            switch (choice)
            {
                case 1:
                    de = de1;
                    PerformArithmeticOperation(x,y,de);
                    break;
                case 2:
                    de = de2;
                    PerformArithmeticOperation(x, y, de);
                    break;
                case 3:
                    de = de3;
                    PerformArithmeticOperation(x, y, de);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
                case 4:
                    de = de4;
                    PerformArithmeticOperation(x, y, de);
                    break;
                
                    


            }
        }

        private static void PerformArithmeticOperation(int x, int y, DelegateArithmetic de)
        {
            Console.WriteLine("Result is: {0}",de(x,y));
        }

        public static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
