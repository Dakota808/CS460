using HW_5.DAL;
using HW_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_5.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext database = new MyDBContext();

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewOrder()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewOrder([Bind(Include = "ID, ODL, Name, DOB, Street, City, State, Zip, County, DateStamp")] Orders order)
        {
          if (ModelState.IsValid)
            {
                database.OrderSet.Add(order);
                database.SaveChanges();
                return RedirectToAction("NewOrder");
            }
            return View(order);
        }

        public ActionResult ViewOrders()
        {
            return View(database.OrderSet.ToList());
        }

    }
}