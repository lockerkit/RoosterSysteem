using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoosterSysteem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EigenGegevens()
        {
            ViewBag.Message = "Eigen gegevens";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Overzicht()
        {
            ViewBag.Message = "Overzicht";

            return View();
        }
    }
}