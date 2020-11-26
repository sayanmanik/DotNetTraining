using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialDemo()
        {
            return PartialView("_pvSample");
        }
    
        //[Authorize]
        public ActionResult JSonDemo()
        {
            var emp = new { EmpId = 1, EmpName = "John Grisham", Salary = 54000 };
            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        public ActionResult RedirectDemo()
        {
            return Redirect("http://www.google.com");
        }

        public ActionResult RedirectToActionDemo()
        {
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute(new { controller = "Home", action = "About" });
        }
        public ActionResult FileResultDemo()
        {
            return File("~/Content/Site.css","text/css");
        }

        [HandleError(View="CustomError")]
        public ActionResult HandleErrorDemo()
        {
            throw new Exception(); // simulating an exception
        }

        [OutputCache(Duration = 10)]
        public ActionResult OutputCacheDemo()
        {
            return View();
        }

        
    }
}