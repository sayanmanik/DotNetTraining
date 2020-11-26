using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedShapeDemo
{

     class Shape
    {
        public virtual void WhoAmI()
        {
            Console.WriteLine("I am Shape");
        }
    }

    class Triangle : Shape
    {
        public override void WhoAmI()
        {
            Console.WriteLine("I'm a traingle");
        }
    }

    class Circle : Shape
    {
        public new void WhoAmI()
        {
            Console.WriteLine("I'm a Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Shape s;
            s = new Triangle();
            s.WhoAmI();

            s = new Circle();
            s.WhoAmI();

        }
    }
}
