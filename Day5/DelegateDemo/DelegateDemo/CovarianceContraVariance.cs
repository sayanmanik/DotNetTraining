using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class CovarianceContraVariance
    {

        delegate void GenericDelegate<T>(T value1, T value2);

        public static void AddNumbers(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public static void AddString(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
        }

        static void Main(string[] args)
        {
            GenericDelegate<int> obj = AddNumbers;
            obj.Invoke(10,20);

            GenericDelegate<string> obj2 = AddString;
            obj2.Invoke("sayan ","manik");
                



        }
    }
}
