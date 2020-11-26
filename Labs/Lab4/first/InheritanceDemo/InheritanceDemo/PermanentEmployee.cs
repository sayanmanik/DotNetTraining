using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class PermanentEmployee : Employee
    {
        double noOfLeaves;
        double providentFunds;

        public double NoOfLeaves
        {
            get
            {
                return NoOfLeaves;
            }
            set
            {
                NoOfLeaves = value;
            }
        }


        public double ProvidentFund
        {
            get
            {
                return providentFunds;
            }
            set
            {
                providentFunds = value;
            }
        }



        public override double Salary
        {
            get
            {
                return salary - providentFunds;
            }

            set
            {
                salary = value;
            }
        }
    }
}
