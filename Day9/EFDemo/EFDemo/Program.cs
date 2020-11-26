using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNetEntities dbContext = new DotNetEntities();


            //Employee employee = new Employee { EmpId = 325, FirstName="Shikhar", LastName = "Dhawan"};
            //dbContext.Employees.Add(employee);
            //dbContext.SaveChanges();
        
            //var empList = from emp in dbContext.Employees
            //              select emp;

            //foreach(Employee e in empList)
            //{
            //    Console.WriteLine(e.EmpId+","+e.FirstName+","+e.LastName);
            //}

            //Console.WriteLine("Enter employee name to modify");
            ////int empId = Convert.ToInt32(Console.ReadLine());
            //string name = Console.ReadLine();

            ////Employee temp = dbContext.Employees.Find(empId);

            //Employee temp = dbContext.Employees.Where(e => e.FirstName == name).FirstOrDefault();


            //temp.Age = 25;
            //dbContext.SaveChanges();


            //dbContext.Employees.Remove(temp);
            //dbContext.SaveChanges();


            ObjectResult<GetParticularEmployee_Result> obj =  dbContext.GetParticularEmployee(123);
        
        
            foreach(GetParticularEmployee_Result emp in obj)
            {
                Console.WriteLine(emp.EmpId+","+emp.FirstName+","+emp.LastName+","+emp.Age);
            }

            Console.WriteLine(dbContext.Employees.Max(e => e.Age));

            var empGroup = dbContext.Employees.GroupBy(e => e.Age).ToList();
            foreach (var group in empGroup)
            {
                Console.WriteLine(group.Key);
                foreach(var e in group)
                {
                    Console.WriteLine(e.EmpId+","+e.FirstName+","+e.LastName);
                }
            }

        }
    }
}
