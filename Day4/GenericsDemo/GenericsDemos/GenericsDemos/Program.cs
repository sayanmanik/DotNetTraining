using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemos
{
    class Calculator<T>
    {
        private T firstNumber;
        private T secondNumber;

        public T FirstNumber { get; set; }
        public T SecondNumber { get; set; }

    }

    class Program
    {

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        static void Main(string[] args)
        {
            Calculator<int> num1 = new Calculator<int>();
            num1.FirstNumber = 10;
            num1.SecondNumber = 20;
            int reslt = num1.FirstNumber + num1.SecondNumber;
            Console.WriteLine(reslt);


            Calculator<string> num2 = new Calculator<string>();
            num2.FirstNumber = "Sayan ";
            num2.SecondNumber = "Manik";
            string reslt2 = num2.FirstNumber + num2.SecondNumber;
            Console.WriteLine(reslt2);

            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine("{0} {1}", x,y);

            string a = "Sayan", b = "Manik";
            Swap(ref a, ref b);
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
