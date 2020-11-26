using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticOperationDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExemple de;
            
            DelegateExemple de1 = new DelegateExemple(ArithmeticOperation.AddNumbers);

            DelegateExemple de2 = new DelegateExemple(ArithmeticOperation.SubtractNumbers);

            DelegateExemple de3 = new DelegateExemple(ArithmeticOperation.MultiplyNumbers);

            DelegateExemple de4 = new DelegateExemple(ArithmeticOperation.DivideNumbers);

            DelegateExemple de5 = new DelegateExemple(ArithmeticOperation.Max);

            int x = 0, y = 0;
            Console.WriteLine("Enter values");

            Console.WriteLine("First value");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second value");
            y = Convert.ToInt32(Console.ReadLine());

            //de = de1;
            //Console.WriteLine("Addition is " + de(x, y));

            //de += de2;
            //Console.WriteLine("Subtraction is " + de(x, y));

            //de += de3;
            //Console.WriteLine("Multiplication is " + de(x, y));

            //de += de4;
            //Console.WriteLine("Divsion is " + de(x, y));

            //de += de5;
            //Console.WriteLine("Max is " + de(x, y));


            Console.WriteLine("1. Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Max");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition is " + de1(x, y));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is " + de2(x, y));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is " + de3(x, y));
                    break;
                case 4:
                    Console.WriteLine("Divsion is " + de4(x, y));
                    break;
                case 5:
                    Console.WriteLine("Max is " + de5(x, y));
                    break;
            }


        }
    }
}
