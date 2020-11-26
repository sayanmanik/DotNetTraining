using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ContractEmployee : Employee
    {
        double perks;

        public double Perks
        {
            get
            {
                return perks;
            }
            set
            {
                perks = value;
            }
        }

        public override double Salary
        {
            get
            {
                return salary + perks;
            }

            set
            {
                salary = value;
            }
        }
    }
}
