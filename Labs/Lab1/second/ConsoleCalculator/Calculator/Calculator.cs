using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double add(int x,double y)
        {
            return x + y;
        }


        public double sub(int x, double y)
        {
            return x - y;

        }

        public double mul(int x, double y)
        {
            return x * y;
        }
        
        public double div(int x, double y)
        {
            return x / y;
        }

        public double modulus(int x ,double y)
        {
            return x % y;
        }
    
    }

}
