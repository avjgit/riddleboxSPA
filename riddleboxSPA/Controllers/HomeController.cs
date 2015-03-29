using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace riddleboxSPA.Controllers
{
    public class HomeController : Controller
    {
        public String ImagePath
        {
            get
            {
                return "~/Pictures/blackpic.jpg";
            }

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebPlayer()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The product built by joint team during Garage 48 in Riga end of March 2015.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}