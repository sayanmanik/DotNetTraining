using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    abstract class Missile : IMissile
    {
        public virtual void bombard()
        {
            Console.WriteLine("This is how any missile will bombard");
            
        }

        public virtual void Fly()
        {
            Console.WriteLine("This is how any missile will fly");
        }

        public virtual void strike()
        {
            Console.WriteLine("This is how any missile will strike");
            
        }
    }
}
