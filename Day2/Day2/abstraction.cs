using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Customer
    {
        int custId;
        String custName;
        String custCity;
        String[] items = new string[3];

        public String[] Items
        {
            get
            {
                return items;

            }

            set
            {
                items = value;
            }
        }


        public int CustId
        {
            get
            {
                return custId;
            }
            set
            {
                custId = value;
            }
        }

        public String CustName
        {
            get
            {
                return custName;
            }
            set
            {
                custName = value;
            }
        }

        public String CustCity
        {
            get
            {
                return custCity;
            }
            set
            {
                custCity = value;
            }
        }

        public string this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

    }


    class abstraction
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.CustId = 123; ;
            c.CustCity = "Kolkata";
            c.CustName = "Sayan";

            c[0] = "Phones";
            c[1] = "Laptop";
            c[2] = "PC";
            

            Console.WriteLine("cust id: {0}, cust city: {1}, cust name: {2} ",c.CustId, c.CustCity, c.CustName);

            Console.WriteLine("Items are: ");
            for(int i = 0; i < c.Items.Length; i++)
            {
                Console.WriteLine("{0}: {1}",(i+1), c[i]);
            }

           

            Console.WriteLine(Maths.add(12, 23));
            Console.WriteLine(Maths.Power(2, 3));
        }
    }
}
