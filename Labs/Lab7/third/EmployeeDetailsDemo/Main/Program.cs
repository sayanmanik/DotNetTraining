using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetailsDemo;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("How many employees");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                AddEmployees(employees);
            }

            DisplayEmployees(employees);
                 
        }

        private static void DisplayEmployees(List<Employee> employees)
        {
            for(int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("Name: {0}, Basic: {1}, PF: {2}",employees[i].Name,employees[i].Basic,employees[i].PF);
                Console.WriteLine("Total: {0}",employees[i].Basic + employees[i].PF);
            }
        }

        private static void AddEmployees(List<Employee> employees)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter basic");
            double basic = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter pf");
            double pf = Convert.ToDouble(Console.ReadLine());


            Employee employee = new Employee(name, basic, pf);

            employees.Add(employee);
        }
    }
}


