using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emplyees = {"Sanjay","Swaroop","Sarad","Akhil","Vinod"};

            var query = emplyees.Where(e => e.Substring(0, 1) == "S");

            foreach (string s in query)
            {
                Console.WriteLine(s+" ");
            }

        }
    }
}
