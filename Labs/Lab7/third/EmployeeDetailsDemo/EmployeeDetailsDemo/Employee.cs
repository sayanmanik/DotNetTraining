using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsDemo
{
    public class Employee
    {
        string name;
        double basic;
        double pf;


        public Employee()
        {

        }


        public Employee(string name,double basic, double pf)
        {
            this.name = name;
            this.basic = basic;
            this.pf = pf;
        }
    
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public double Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }


        public double PF
        {
            get
            {
                return pf;
            }
            set
            {
                pf = value;
            }
        }

    }

}
