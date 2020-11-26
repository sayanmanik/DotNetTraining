using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitValidationException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter customer id");
                int id = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter customer name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter city");
                string city = Console.ReadLine();

                Console.WriteLine("Enter phone number");
                string phn = Console.ReadLine();

                Console.WriteLine("Enter credit Limit");
                double limit = Convert.ToDouble(Console.ReadLine());

                Customer c = new Customer(id,name,address,city,phn,limit);

                Console.WriteLine("Id: "+c.CustomerId);
                Console.WriteLine("Name: "+c.CustomerName);
                Console.WriteLine("Address: "+c.Address);
                Console.WriteLine("City: "+c.City);
                Console.WriteLine("Credit Limit: {0}", c.CreditLimit);
                Console.WriteLine("Phone Numer: "+c.Phone);
                

            }
            catch (InvalidCreditLimitException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
