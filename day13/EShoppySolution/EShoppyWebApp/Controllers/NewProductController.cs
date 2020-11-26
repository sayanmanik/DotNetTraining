using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShoppyDAL;


namespace EShoppyWebApp.Controllers
{
    public class NewProductController : Controller
    {
        EShoppyRepository repo = new EShoppyRepository();

        // GET: NewProduct
        public ActionResult Index()
        {

            List<Product> products = repo.GetProducts();
            List<Models.Product> productsList = new List<Models.Product>();

            foreach (var item in products)
            {
                Models.Product p = new Models.Product();
                p.ProductId = item.ProductId;
                p.ProductName = item.ProductName;
                p.ProductPrice = item.ProductPrice;
                p.ProductDescription = item.ProductDescription;
                p.ExistsInStock = item.ExistsInStock;
                p.CategoryId = item.CategoryId;

                productsList.Add(p);

            }

            return View("ViewProducts", productsList);


            return View();
        }

        // GET: NewProduct/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewProduct/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewProduct/Create
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

        // GET: NewProduct/Edit/5
        public ActionResult Edit(Models.Product product)
        {
            return View(product);
        }

        // POST: NewProduct/Edit/5
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditProduct(Models.Product product)
        {
            try
            {
                // TODO: Add update logic here

                Product dalProduct = new Product();
                dalProduct.ProductId = product.ProductId;
                dalProduct.ProductName = product.ProductName;
                dalProduct.ProductPrice = product.ProductPrice;
                dalProduct.ProductDescription = product.ProductDescription;
                dalProduct.ExistsInStock = product.ExistsInStock;
                dalProduct.CategoryId = product.CategoryId;

                bool result = repo.UpdateProductProfile(dalProduct);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else{
                    ViewBag.errmsg = "Error";
                    return View();
                }
                
                
               
            }
            catch
            {
                return View();
            }
        }

        // GET: NewProduct/Delete/5
        public ActionResult Delete(Models.Product product)
        {
            return View(product);
        }

        // POST: NewProduct/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteProduct(Models.Product product)
        {
            try
            {
                // TODO: Add delete logic here


                Product dalProduct = new Product();
                dalProduct.ProductId = product.ProductId;
                dalProduct.ProductName = product.ProductName;
                dalProduct.ProductPrice = product.ProductPrice;
                dalProduct.ProductDescription = product.ProductDescription;
                dalProduct.ExistsInStock = product.ExistsInStock;
                dalProduct.CategoryId = product.CategoryId;

                bool result = repo.DeleteProductProfile(dalProduct.ProductId);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.errmsg = "Error";
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
