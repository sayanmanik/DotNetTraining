using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator c = new Calculator.Calculator();
            
            int x;
            double y;

            Console.WriteLine("Addition");
            Console.WriteLine("Enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result is :{0}",c.add(x, y));



            Console.WriteLine("Subtraction");
            Console.WriteLine("Enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result is :{0}", c.sub(x, y));



            Console.WriteLine("Multiplication");
            Console.WriteLine("Enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result is :{0}", c.mul(x, y));


            Console.WriteLine("Division");
            Console.WriteLine("Enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result is :{0}", c.div(x, y));

            Console.WriteLine("Modulus");
            Console.WriteLine("Enter first number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result is :{0}", c.modulus(x, y));

        }
    }
}
