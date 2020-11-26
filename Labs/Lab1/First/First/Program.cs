using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empList = new Employee[10];
            for (int i = 0; i < empList.Length; i++)
            {
                Console.WriteLine("Enter employee id");
                int empId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter employee name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter city");
                string city = Console.ReadLine();

                Console.WriteLine("Enter dept name");
                string dept = Console.ReadLine();

                Console.WriteLine("Enter salary");
                double salary = Convert.ToDouble(Console.ReadLine());

                Employee employee = new Employee();
                employee.EmployeeId = empId;
                employee.EmployeeName = name;
                employee.City = city;
                employee.Address = address;
                employee.Department = dept;
                employee.Salary = salary;

                empList[i] = employee;


            }

            for(int i = 0; i < empList.Length; i++)
            {
                Console.WriteLine("Name {0} and salary {1} ",empList[i].EmployeeName, empList[i].Salary);
            }
                            

            }
        }
    }

