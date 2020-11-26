using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

        abstract class Employee
        {
            protected int employeeId;
            protected string employeeName;
            protected string address;
            protected string city;
            protected string dept;
            protected double salary;


   

            public int EmployeeId
            {
                get
                {
                    return employeeId;
                }
                set
                {
                    employeeId = value;
                }
            }

            public string EmployeeName
            {
                get
                {
                    return employeeName;
                }
                set
                {
                    employeeName = value;
                }
            }


            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    address = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }

            public string Department
            {
                get
                {
                    return dept;
                }
                set
                {
                    dept = value;
                }

            }

            public abstract double Salary
            {
                get;
                set;
        
            }

        }
    }

