using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDetails
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier s = new Supplier();
            Supplier t = new Supplier();
            s.AcceptDetails(t);
            Supplier supplier = s.DisplayDetails();

            Console.WriteLine("Supplier Id: {0}, Supplier Name: {1}, Phone number: {2}, City: {3}, Email: {4}",supplier.SupplierId,supplier.SupplierName,supplier.PhoneNumber,supplier.City,supplier.Email);
        }
    }
}
