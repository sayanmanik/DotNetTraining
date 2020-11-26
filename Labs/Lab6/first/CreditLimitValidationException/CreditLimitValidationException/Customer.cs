using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitValidationException
{
    class Customer
    {
        int customerId;
        string customerName;
        string address;
        string city;
        string phn;
        double creditLimit;


        public Customer(int customerId, string customerName,string address, string city, string phn, double creditLimit)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.city = city;
            this.phn = phn;
            if (creditLimit > 50000)
            {
                throw new InvalidCreditLimitException("Credit limit should not be more than 50000");
            }
            this.creditLimit = creditLimit;
            //Console.WriteLine("Credit Limit in Customer "+this.creditLimit);
        }


        public Customer()
        {

        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
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

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }


        public string Phone
        {
            get
            {
                return phn;
            }
            set
            {
                phn = value;
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

        public double CreditLimit
        {
            get
            {
                return creditLimit;
            }
            set
            {
                creditLimit = value;
            }
        }
    }
}
