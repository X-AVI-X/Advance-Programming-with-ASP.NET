using Product.Models;
using Product.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.GetAll();
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductStructure p)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.Add(p);
                return RedirectToAction("Index");
            }
            return View();

        }


    }
}