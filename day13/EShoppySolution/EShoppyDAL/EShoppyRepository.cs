using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShoppyDAL
{
    public class EShoppyRepository
    {
        private EShoppyDBEntities dbContext = null;

        public EShoppyRepository()
        {
            dbContext = new EShoppyDBEntities();
        }

        //CRUD operations

        //Customer

        public bool AddCustomer(Customer newCustomer)
        {
            bool status = false;
            try
            {
                dbContext.Customers.Add(newCustomer);
                dbContext.SaveChanges();
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;
        }


        public string ValidateCustomer(string Email,string password)
        {
            string customerId = "";
            try
            {
                var customer = dbContext.Customers.Where(c => c.EmailId == Email && c.Password == password).ToList<Customer>();
                if (customer.Count == 1)
                {
                    customerId = customer[0].CustomerId;
                }
            
            }
            catch(Exception e)
            {
                customerId = "";
            }

            return customerId;
        }

        public Customer ViewCustomerProfile(string customerId)
        {
            Customer temp = null;
            try
            {
                temp = dbContext.Customers.Find(customerId);
            }
            catch (Exception e)
            {
                temp = null;
            }
            return temp;

        }

        public bool UpdateCustomerProfile(Customer newCustomer)
        {

            bool status = false;
            try
            {
                Customer oldCustomer = ViewCustomerProfile(newCustomer.CustomerId);
                oldCustomer.Country = newCustomer.CustomerId;
                oldCustomer.Address = newCustomer.Address;
                oldCustomer.EmailId = newCustomer.EmailId;
                oldCustomer.Password = newCustomer.Password;
                oldCustomer.CustomerName = newCustomer.CustomerName;
                oldCustomer.CustomerId = newCustomer.CustomerId;
                oldCustomer.DeliveryAddress = newCustomer.DeliveryAddress;
                oldCustomer.City = newCustomer.City;
                dbContext.SaveChanges();

                status = true;
            }
            catch (Exception e)
            {
                status = true;
            }

            return status;
        }


        public bool DeleteCustomerProfile(string customerId)
        {
            bool status = false;
            try
            {
                Customer temp = ViewCustomerProfile(customerId);

                dbContext.Customers.Remove(temp);
                dbContext.SaveChanges();

                status = true;

            }
            catch(Exception e)
            {
                status = false;
            }

            return status;
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        // This method will be invoked from the EShoppyAPIService Controller
        public List<Catogory> GetCatogories()
        {
            return dbContext.Catogories.ToList();
        }


        // Product CRUD operations

        // Add
        public bool AddProduct(Product newProduct)
        {
            bool status = false;
            try
            { 
                dbContext.Products.Add(newProduct);

                dbContext.SaveChanges();
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;
        }


        // Show
        public Product ViewProductProfile(string productId)
        {
            Product temp = null;
            try
            {
                temp = dbContext.Products.Find(productId);
            }
            catch (Exception e)
            {
                temp = null;
            }
            return temp;

        }

        // Update 
        public bool UpdateProductProfile(Product newProduct)
        {

            bool status = false;
            try
            {
                Product oldProduct = ViewProductProfile(newProduct.ProductId);

                //Product oldProduct = new Product();
                oldProduct.ProductId = newProduct.ProductId;
                oldProduct.ProductName = newProduct.ProductName;
                oldProduct.ProductPrice = newProduct.ProductPrice;
                oldProduct.ProductDescription = newProduct.ProductDescription;
                oldProduct.ExistsInStock = newProduct.ExistsInStock;

                dbContext.SaveChanges();

                status = true;
            }
            catch (Exception e)
            {
                status = false;
            }

            return status;
        }

        // Delete

        public bool DeleteProductProfile(string productId)
        {
            bool status = false;
            try
            {
                Product newProduct = ViewProductProfile(productId);

                //Product temp = ViewProductProfile(newProduct.ProductId);
                //Product temp = new Product();
                //temp.ProductId = newProduct.ProductId;
                //temp.ProductName = newProduct.ProductName;
                //temp.ProductPrice = newProduct.ProductPrice;
                //temp.ProductDescription = newProduct.ProductDescription;
                //temp.ExistsInStock = newProduct.ExistsInStock;


                dbContext.Products.Remove(newProduct);
                dbContext.SaveChanges();

                status = true;

            }
            catch (Exception e)
            {
                status = false;
            }

            return status;
        }


    }
}
