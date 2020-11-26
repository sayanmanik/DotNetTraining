using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMDemo
{
    class CrudOperations
    {
        public void insertDepartment(int id, string name,int empId)
        {
            using (var dbContext = new DotNetEntities())
            {
                var dept = new Department() { DeptId = id, Name = name, EmployeeId = empId };
                dbContext.Departments.Add(dept);
                dbContext.SaveChanges();

            }

            Console.WriteLine("Department added");
        }

        public void displayDepartment()
        {
            using (var dbContext = new DotNetEntities())
            {
                List<Department> list = (from d in dbContext.Departments select d).ToList();

                foreach (var department in list)
                {
                    Console.WriteLine(department.DeptId+","+department.Name+","+department.EmployeeId);
                }
            }

            Console.WriteLine("Displayed all departments");
        }

        public void displayDepartmentById(int id)
        {
            using(var dbContext = new DotNetEntities())
            {
                List<Department> list = (from d in dbContext.Departments
                                         where d.DeptId == id
                                         select d).ToList();

                foreach (var d in list)
                {
                    Console.WriteLine(d.DeptId+","+d.Name);
                }
            }
            Console.WriteLine("Displayed all departments by id");
        }


        public void updateDepartment(int oldVal, string newVal)
        {
            using (var dbContext = new DotNetEntities())
            {
                Department dept = (from d in dbContext.Departments
                            where d.DeptId == oldVal
                            select d).FirstOrDefault();

                dept.Name = newVal;
            }

            Console.WriteLine("Department updated");

        }

        public void displayByProc()
        {
            using(var dbContext = new DotNetEntities())
            {
                var employees =  dbContext.GetEmployees();

                foreach(var item in employees)
                {
                    Console.WriteLine(item.EmpId+","+item.FirstName+","+item.LastName);
                }

            }
        }

    }
}
