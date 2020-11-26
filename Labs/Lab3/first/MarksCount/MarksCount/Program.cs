using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int foundation, webBasic, dotNet, empId;
            string name;


            Console.WriteLine("Enter name for emp id");
            empId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter name for name");
            name = Console.ReadLine();


            Console.WriteLine("Enter Marks for Foundation Course(Marks should be within 0 to 100)");
            foundation = Convert.ToInt32(Console.ReadLine());

            if(foundation< 0 || foundation > 100)
            {
                foundation = 0;
            }


            Console.WriteLine("Enter Marks for WebBasic Course(Marks should be within 0 to 100)");
            webBasic = Convert.ToInt32(Console.ReadLine());

            if (webBasic < 0 || webBasic > 100)
            {
                webBasic = 0;
            }

            Console.WriteLine("Enter Marks for DotNet Course(Marks should be within 0 to 100)");
            dotNet = Convert.ToInt32(Console.ReadLine());

            if (dotNet < 0 || dotNet > 100)
            {
                dotNet = 0;
            }


            Participant p = new Participant(empId, name,foundation, webBasic, dotNet);
            Console.WriteLine("Total is: "+p.total());
            Console.WriteLine("Percentage is: "+p.percentageMarks()+ "%");


        }
    }
}
