using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;

namespace MVCStock.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        MVCStockEntities db = new MVCStockEntities();
        public ActionResult Index()
        {
            var result = db.Products.ToList();
            return View(result);
        }
    }
}