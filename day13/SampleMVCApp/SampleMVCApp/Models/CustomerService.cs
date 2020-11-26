using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class CustomerService
    {
        static List<Customer> customerList = null;

        static CustomerService()
        {
            customerList = new List<Customer>()
            {
                new Customer{Id=1,Name="Mary",City="Delhi"},
                new Customer{Id=2,Name="Raj",City="Chennai"},
                new Customer{Id=3,Name="Mohan",City="Bengaluru"},
            };


        }
    
        public static List<Customer> GetCustomers()
        {
            return customerList;
        }

        public static bool AddCustomer(Customer customer)
        {
            bool status = false;
            if (customer != null)
            {
                customerList.Add(customer);
                status = true;
            }
            return status;
        }


        
    }


}