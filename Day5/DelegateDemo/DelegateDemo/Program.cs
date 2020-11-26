using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public class Small
    {

    }

    public class Big : Small
    {

    }


    public class Bigger : Big
    {

    }
    
    public delegate Small covarDal(Big big);
    class Program
    {

       public static Big Method1(Big bg)
        {
            Console.WriteLine("Method 1");
            return new Big();
        } 

        public static Small Method2(Big big)
        {
            Console.WriteLine("Method 2");
            return new Small();
        }

        public static Small Method3(Small small)
        {
            Console.WriteLine("Method 3");
            return new Small();
        }

        static void Main(string[] args)
        {
            //covarDal covarDal = Method1;

            //covarDal(new Big());

            //covarDal = Method2;

            //covarDal(new Big());


            covarDal covarDal = Method1;

            covarDal = Method2;

            covarDal = Method3;

            covarDal(new Big());
        }
    }
}
