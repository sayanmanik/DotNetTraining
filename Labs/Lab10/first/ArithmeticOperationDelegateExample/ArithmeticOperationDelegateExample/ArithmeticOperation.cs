using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int DelegateExemple(int x,int y);

namespace ArithmeticOperationDelegateExample
{
    public class ArithmeticOperation
    {
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }



        public static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }



        public static int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }


        public static int DivideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Max(int num1, int num2)
        {
            int max = num1 > num2 ? num1: num2;
            return max;
        }


    }
}
