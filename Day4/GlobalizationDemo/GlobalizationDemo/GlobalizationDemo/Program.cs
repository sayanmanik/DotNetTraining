using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using System.Threading;

namespace GlobalizationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo info = CultureInfo.CurrentCulture;
            Console.WriteLine("{0}, {1}",info.NativeName,info.Name);

            CultureInfo cultureInfo = new CultureInfo("hi-IN");

            CultureInfo currentCulture = cultureInfo;
            Console.WriteLine(currentCulture.NativeName+","+currentCulture.Name);


        }
    }
}
