using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;

namespace MVCStock.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MVCStockEntities db = new MVCStockEntities();
        public ActionResult Index()
        {
            var result = db.Categories.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult NewCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCategory(Categories p1)
        {
            db.Categories.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}