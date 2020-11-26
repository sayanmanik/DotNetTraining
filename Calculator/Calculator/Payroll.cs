using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Payroll
    {
        public int calculatePayroll(out int num1 , out int num2)
        {
            num1 = 20000;
            num2 = 4000;

            return num1 - num2;
        }
    }
}
