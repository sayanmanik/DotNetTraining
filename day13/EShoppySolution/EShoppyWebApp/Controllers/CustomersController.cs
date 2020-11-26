using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShoppyDAL;

namespace EShoppyWebApp.Controllers
{
    public class CustomersController : Controller
    {

        EShoppyRepository repo = new EShoppyRepository();

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details()
        {
            string customerId = Session["CustomerId"].ToString();
            Customer customer = repo.ViewCustomerProfile(customerId);

            //translate entity customer to model object
            Models.Customer modCustomer = new Models.Customer();
            modCustomer.CustomerId = customer.CustomerId;
            modCustomer.CustomerName = customer.CustomerName;
            modCustomer.Address = customer.Address;
            modCustomer.City = customer.City;
            modCustomer.Country = customer.Country;
            modCustomer.EmailId = customer.EmailId;
            modCustomer.Password = customer.Password;
            modCustomer.DeliveryAddress = customer.DeliveryAddress;
            
            return View("ViewProfile",modCustomer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(string id)
        {
            Customer customer = repo.ViewCustomerProfile(id);
            Models.Customer modCustomer = new Models.Customer();
            modCustomer.CustomerId = customer.CustomerId;
            modCustomer.CustomerName = customer.CustomerName;
            modCustomer.Address = customer.Address;
            modCustomer.City = customer.City;
            modCustomer.Country = customer.Country;
            modCustomer.EmailId = customer.EmailId;
            modCustomer.Password = customer.Password;
            modCustomer.DeliveryAddress = customer.DeliveryAddress;
           
            return View(modCustomer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Models.Customer customer)
        {
            try
            {
                // TODO: Add update logic here

                Customer dalCustomer = new Customer();
                //translate model customer to dal customer
                dalCustomer.CustomerId = id;
                dalCustomer.CustomerName = customer.CustomerName;
                dalCustomer.Address = customer.Address;
                dalCustomer.City = customer.City;
                dalCustomer.Country = customer.City;
                dalCustomer.EmailId = customer.EmailId;
                dalCustomer.Password = customer.Password;
                dalCustomer.DeliveryAddress = customer.DeliveryAddress;


                bool result = repo.UpdateCustomerProfile(dalCustomer);
                if (result)
                {
                    ViewBag.msg = "Profile edited...";
                }
                else
                {
                    ViewBag.errmsg = "Error";
                }

                return View();
            }
            catch
            {

                return View("Error");
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(string id)
        {

            Customer customer = repo.ViewCustomerProfile(id);


            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bool result = repo.DeleteCustomerProfile(id);
                if (result)
                {
                    Session.Clear(); // Delete all the key-value pair from Session object
                    return RedirectToAction("Login","Home");
                }
                else
                {
                    ViewBag.errmsg = "Error!!";
                    return View();
                }
                
                
            }
            catch
            {
                return View();
            }
        }
    }
}
