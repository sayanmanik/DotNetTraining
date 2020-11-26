using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class CustomException : ApplicationException
    {
        //public CustomException() : base()
        //{

        //}

        public CustomException(string msg) : base(msg)
        {
            //Console.WriteLine(msg);
        }

    }
}
