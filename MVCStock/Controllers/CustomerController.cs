using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;

namespace MVCStock.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        MVCStockEntities db = new MVCStockEntities();
        public ActionResult Index()
        {
            var result = db.Customers.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCustomer(Customers p1)
        {
            db.Customers.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}