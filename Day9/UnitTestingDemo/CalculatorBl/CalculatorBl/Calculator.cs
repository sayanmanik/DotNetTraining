using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBl
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool CheckEven(int num1)
        {
            if (num1 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
