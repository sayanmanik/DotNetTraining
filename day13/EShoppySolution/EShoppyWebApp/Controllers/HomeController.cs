using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShoppyDAL;

namespace EShoppyWebApp.Controllers
{
    public class HomeController : Controller
    {
        EShoppyRepository repo = new EShoppyRepository();
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Customer customer)
        {
            Customer dialCustomer = new Customer();
            dialCustomer.CustomerId = customer.CustomerId;
            dialCustomer.CustomerName = customer.CustomerName;
            dialCustomer.City = customer.City;
            dialCustomer.Address = customer.Address;
            dialCustomer.Country = customer.Country;
            dialCustomer.DeliveryAddress = customer.DeliveryAddress;
            dialCustomer.EmailId = customer.EmailId;
            dialCustomer.Password = customer.Password;
            //repo.AddCustomer(dialCustomer);

            bool result = repo.AddCustomer(dialCustomer);
            if (result)
            {
                ViewBag.msg = "Customer registration successful";
            }
            else
            {
                ViewBag.errmsg = "Error while adding customer. Pls try again!";
            }
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Customer customer)
        {
            string custId = repo.ValidateCustomer(customer.EmailId, customer.Password);
            if (custId == "" || custId == null)
            {
                ViewBag.errmsg = "Login Failed, Pls try again";
                return View();
            }
            else
            {
                Session["CustomerId"] = custId;
                Session["EmailAddress"] = customer.EmailId;
                return RedirectToAction("Index","NewProduct");
            }
        }


        public ActionResult ViewProducts()
        {
            List<Product> products = repo.GetProducts();
            return View(products);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}