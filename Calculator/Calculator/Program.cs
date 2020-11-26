using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Calculator c = new Calculator(12,34);
            Console.WriteLine("Addition " + c.add());
            Console.WriteLine("Subtraction: "+c.sub());
            Console.WriteLine("Multiplication: "+c.mul());
            Console.WriteLine("Division: "+c.div());

            Payroll p = new Payroll();
            int x, y;
            Console.WriteLine();
            Console.WriteLine("Calculated salary: "+p.calculatePayroll(out x,out y));


        }
    }
}
