using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Page1()
        {
            string answer = "Enter a valid request";
            string text = Request.QueryString["text1"];
            string too = Request.QueryString["to"];
            ViewBag.RequestMethod = "GET";

            double result;

            if(too == "f" || too == "F")
            {
                result = (double.Parse(text) * 1.4) + 32;
                answer = "" + result;
            }
            else if(too == "x" || too == "X")
            {
                result = (double.Parse(text) - 32) / 1.4;
                answer = "" + result;
            }
            else
            {

            }
            ViewBag.Message = answer;
            return view();

        }
        [HttpGet]
        public ActionResult Page2()
        {
            ViewBag.RequestMethod = "GET";

            return View();
        }

        [HttpPost]
        public ActionResult Page2(FormCollection form)
        {
            ViewBag.RequestMethod = "Post";
            string value = Request.Form["Amount"];
            string input = Request.Form["input"];
            string output = Request.Form["output"];

            double valueS = double.Parse(value);

            if (input == "dollar")
            {
                valueS = valueS;
            }
            else if (input == "pound")
            {
                valueS = valueS * 1.31;
            }
            else if (input == "Yen")
            {
                valueS = valueS * 114.30;
            }
            else
            {
                value = "Enter a value that is valid";
                ViewBag.Message = value;
                return View();
            }

            if (input == "dollar")
            {
                valueS = valueS;
            }
            else if (input == "pound")
            {
                valueS = valueS / 1.31;
            }
            else if (input == "Yen")
            {
                valueS = valueS / 114.30;
            }
            else
            {
                value = "Enter a value that is valid";
                ViewBag.Message = value;
                return View();
            }

            value = "" + valueS;
            ViewBag.Message = value;

            return View();
        }

        [HttpGet]
        public ActionResult Page3()
        {
            return view();
        }

        [HttpPost]
        public ActionResult Page3(double amount, double rate, double length)
        {
            double s = length * 12;
            double t = rate / 12;
            double cal = ((Math.Pow(1 + t), s)) - 1) / (t * Math.Pow((1 + t), s)));
            double x = amount / cal;

            ViewBag.Month = x + "";
            ViewBag.Total = x * s + "";
            return View();
        }
    }
}