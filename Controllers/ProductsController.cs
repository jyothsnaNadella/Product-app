using ProductsProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductsProject.Controllers
{
    public class ProductsController : Controller
    {
        static List<Products> lstProducts = new List<Products>();
        //// GET: Products
        public ActionResult Products()
        {
            ////return new List<string>();
            //ViewBag.Products = new List<string>()
            //{
            //    "test",
            //    "mobile",
            //    "tv"
            //};
            Products objProducts = new Products()
            {
                ProductName = "TV",
                Price = "50",
                Description = "Lgcompany"
            };
            return View(objProducts);
        }

        //public ActionResult Products(int id)
        //{
        //    ProductContext objempcontext = new ProductContext();
        //    Products objProduct = objempcontext.Products.Single(pro => pro.ProductId == id);
        //    return View(objProduct);
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Products(Products product)
        //{   
        //    if (!ModelState.IsValid)
        //    {
        //        return View("Login", lstProducts);
        //    }
        //    lstProducts.Add(product);
        //    return RedirectToAction("Index");
        //}
    }
}