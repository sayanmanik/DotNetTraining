using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird b = new Bird("Eagle" , double.Parse("200"));
            b.fly();
            b.fly(double.Parse("300"));
        }
    }
}
