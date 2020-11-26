using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>(){
            //    new Employee(){EmployeeNo=1,Age=22,EmployeeName="Sayan"},
            //    new Employee(){EmployeeNo=2,Age=30,EmployeeName="Manik"},
            //    new Employee(){EmployeeNo=3,Age=34,EmployeeName="Piku"}
            //};

            //var query = from emp in employees
            //            where emp.Age>=30 && emp.Age<=40
            //            select emp;

            //foreach (Employee e in query)
            //{
            //    Console.WriteLine(e.EmployeeNo+","+e.EmployeeName+","+e.Age);
            //}

            DataClasses1DataContext context = new DataClasses1DataContext();
            var query = from emp in context.Employees orderby emp.FirstName,emp.LastName select emp;

            foreach (Employee e in query)
            {
                Console.WriteLine(e.EmpId+","+e.Age+","+e.FirstName+","+e.LastName);
            }

            var query1 = from dept in context.Departments select dept;

            foreach (Department d in query1)
            {
                Console.WriteLine(d.DeptId+","+d.Name+","+d.EmployeeId);
            }

            var joinQuery = from q in query
                            join d in query1
                            on q.EmpId equals d.EmployeeId 
                            select new { q.EmpId };

            foreach(var item in joinQuery)
            {
                Console.WriteLine(item.EmpId);
            }
        }
    }
}
