using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.name = DateTime.Now;
            ViewData["name"] = DateTime.Now;

            // TempData.name = DateTime.Now;
            TempData["name"] = DateTime.Now;


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


        //MVC Scaffolding = mechanism which generated templates/views automatically for CRUD operations
        public ActionResult Details()
        {
            Customer customer = new Customer { Id=101, Name="Sayan" ,City="New Jersey"};
            return View(customer);
        }


        public ActionResult Show()
        {
            List<Customer> customers= CustomerService.GetCustomers();
            return View(customers);
        }

        //GET: CREATE 
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Customer customer)
        {
            bool result = CustomerService.AddCustomer(customer);
            if (result == true)
            {
                return RedirectToAction("Show");
            }
            //{
            //    ViewBag.msg = "Customer record added!";
            //}
            //else
            //{
            //    ViewBag.msg = "Error while adding customer record!!";
            //}
            else
            {
                ViewBag.msg = "Error";
                return View();
            }
           
        }
        
    }
}