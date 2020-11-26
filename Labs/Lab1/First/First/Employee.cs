using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Employee
    {
        private int employeeId;
        private string employeeName;
        private string address;
        private string city;
        private string dept;
        private double salary;

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

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }

        }

    }
}
