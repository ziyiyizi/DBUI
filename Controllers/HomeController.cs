using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult BookSearch()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Classify()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}