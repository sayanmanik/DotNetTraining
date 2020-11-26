using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using category = EShoppyAPIService.Models.Category;
using EShoppyDAL;
using System.Net.Http;

namespace EShoppyWebApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        IEnumerable<category> categorylist = null;
        public ActionResult Index()
        {
            using(var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44325/");
                var webtask = webclient.GetAsync("api/EShoppyAPI");
                webtask.Wait();
                var responseTask = webtask.Result;

                
                if (responseTask.IsSuccessStatusCode)
                {
                    var responseData = responseTask.Content.ReadAsAsync<List<category>>();
                    responseData.Wait();
                    categorylist = responseData.Result;
                }
                else
                {
                   
                    categorylist = null;
                    ModelState.AddModelError("key1","Services currently offline. try again");
                }
            }
            return View(categorylist);
        }
    }
}