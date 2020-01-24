using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rd484215mis4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "All about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact information.";

            return View();
        }
    }
}