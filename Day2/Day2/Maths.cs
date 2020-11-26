using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    static class Maths
    {
        public static int add(int x,int y)
        {
            return x + y;
        }

        public static double Power(double n,double p)
        {
            double res = 1;
            for(int i = 0; i < p; i++)
            {
                res = res * n;
            }
            return res;
        }


    }
}
