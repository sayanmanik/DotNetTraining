using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using EShoppyDAL;

namespace EShoppyAPIService.Controllers
{
    public class EShoppyAPIController : ApiController
    {
        // GET: EShoppyAPI

        
        public JsonResult<List<Models.Category>> GetCategories()
        {
            EShoppyRepository repo = new EShoppyRepository();

            List<Catogory> catogories = repo.GetCatogories();

            List<Models.Category> categoryList = new List<Models.Category>();

            foreach (var item in catogories)
            {
                Models.Category category = new Models.Category();
                category.CategoryId = item.CategoryId;
                category.CategoryName = item.CategoryName;
                category.CategoryDescription = item.CategoryDescription;
                categoryList.Add(category);
            }

            var jsondata = Json(categoryList);
            return jsondata;
        }
    }
}