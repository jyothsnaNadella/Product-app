using Antlr.Runtime.Tree;
using ProductsProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductsProject.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
       
        public ActionResult Index()
        {
            ProductContext objempcontext = new ProductContext();
            List<Products> lstProducts = objempcontext.Products.ToList();
            return View(lstProducts);
        }
        public ActionResult Details(int id)
        {
            ProductContext objempcontext = new ProductContext();
            Products objProduct = objempcontext.Products.Single(pro => pro.ProductId == id);
            return View(objProduct);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Products objproduct = new Products();
            // Retrieve form data using form collection
            objproduct.ProductName = formCollection["ProductName"];
            objproduct.Price = formCollection["Price"];
            objproduct.Description = formCollection["Description"];
            ProductBusinessLayer objBussinessLayer = new ProductBusinessLayer();
            objBussinessLayer.AddProduct(objproduct);
            return RedirectToAction("Index");
        }
    }
}