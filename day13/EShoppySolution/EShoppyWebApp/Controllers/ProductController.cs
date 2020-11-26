using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShoppyDAL;


namespace EShoppyWebApp.Controllers
{
    public class ProductController : Controller
    {

        EShoppyRepository repo = new EShoppyRepository();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(string id)
        {

            Product product = repo.ViewProductProfile(id);
            Models.Product oldProduct = new Models.Product();

            oldProduct.ProductId = product.ProductId;
            oldProduct.ProductName = product.ProductName;
            oldProduct.ProductPrice = product.ProductPrice;
            oldProduct.ProductDescription = product.ProductDescription;
            oldProduct.ExistsInStock = product.ExistsInStock;


            return View(oldProduct);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Models.Product oldProduct)
        {
            try
            {

                Product newProduct = new Product();
                newProduct.ProductId = oldProduct.ProductId;
                newProduct.ProductName = oldProduct.ProductName;
                newProduct.ProductPrice = oldProduct.ProductPrice;
                newProduct.ProductDescription = oldProduct.ProductDescription;
                newProduct.ExistsInStock = oldProduct.ExistsInStock;

                bool result = repo.AddProduct(newProduct);

                // TODO: Add insert logic here


                if (result)
                {
                    ViewBag.msg = "Product added successfully";
                }
                else
                {
                    ViewBag.errmsg = "Error while adding product... pls try again";
                }

                return RedirectToAction("ViewProducts","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(string id)
        {

            Product product = repo.ViewProductProfile(id);
            Models.Product oldProduct = new Models.Product();

            oldProduct.ProductId = product.ProductId;
            oldProduct.ProductName = product.ProductName;
            oldProduct.ProductPrice = product.ProductPrice;
            oldProduct.ProductDescription = product.ProductDescription;
            oldProduct.ExistsInStock = product.ExistsInStock;

            return View(oldProduct);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Models.Product oldProduct)
        {
            try
            {

                Product product = new Product();
                product.ProductId = id;
                product.ProductName = oldProduct.ProductName;
                product.ProductPrice = oldProduct.ProductPrice;
                product.ProductDescription = oldProduct.ProductDescription;
                product.ExistsInStock = oldProduct.ExistsInStock;

                // TODO: Add update logic here

                bool result = repo.UpdateProductProfile(product);

                if (result)
                {
                    ViewBag.msg = "Successfully edited";
                }
                else
                {
                    ViewBag.errmsg = "Erro in editing.. Pls try again";
                }

                return RedirectToAction("ViewProducts","Home");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(string id)
        {

            Product product = repo.ViewProductProfile(id);
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bool result = repo.DeleteProductProfile(id);

                if (result)
                {
                    return RedirectToAction("ViewProducts","Home");
                }
                else
                {
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
