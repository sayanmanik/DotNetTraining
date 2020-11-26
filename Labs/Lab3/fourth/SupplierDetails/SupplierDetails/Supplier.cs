using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDetails
{
    class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string city;
        private string phoneNo;
        private string email;

        public int SupplierId
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
            }
        }

        public string SupplierName
        {
            get
            {
                return supplierName;
            }
            set
            {
                supplierName = value;
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

        public string PhoneNumber
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }







        public void AcceptDetails(Supplier s)
        {
            Console.WriteLine("Enter supplier id");
            this.supplierID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter supplier name");
            this.supplierName = Console.ReadLine();

            Console.WriteLine("Enter city name");
            this.city = Console.ReadLine();

            Console.WriteLine("Enter phone number");
            this.phoneNo = Console.ReadLine();

            Console.WriteLine("Enter email");
            this.email = Console.ReadLine();


        }

        public Supplier DisplayDetails()
        {
            Supplier s = new Supplier();
            s.SupplierId = supplierID;
            s.SupplierName = supplierName;
            s.PhoneNumber = phoneNo;
            s.City = city;
            s.Email = email;

            return s;
        }

    }
}
