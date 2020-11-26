using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{

    //User Request:    http://localhostL31230/Home/Index mapped to MVC Route
    //   http://localhostL31230/ 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string val = null;
            //if (RouteData.Values["id"] != null)
            //{
            //     val = RouteData.Values["id"].ToString(); 
            //}

            //if (id != null)
            //{
            //    return Content(id);
            //}
            //else
            //{
                return View();
            //}
            //return Content("ID value is:"+id+",Age value is:"+age);
            
            //return View(val);
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

        //Return type of action method must be ActionResult or content & nothing else
        public ActionResult MyAction(string id)
        {
            return Content("My Action:" + id);

        }
    }
}