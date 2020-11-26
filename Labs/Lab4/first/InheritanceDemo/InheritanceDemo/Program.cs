using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent Employee");
            Console.WriteLine("2. Contract Employee");

            Console.WriteLine("Enter your choice");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    PermanentEmployee permanentEmployee = new PermanentEmployee();
                    Console.WriteLine("Enter salary");
                    permanentEmployee.Salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter provident fund");
                    permanentEmployee.ProvidentFund = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Final Salary {0}",permanentEmployee.Salary);
                    break;


                case 2:
                    ContractEmployee contractEmployee = new ContractEmployee();
                    Console.WriteLine("Enter salary");
                    contractEmployee.Salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter parks");
                    contractEmployee.Perks = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(contractEmployee.Salary);
                    break;
            }

        }
    }
}
