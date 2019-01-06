using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoosterSysteem.Models;

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
            if (Session["userID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                ViewBag.Message = "Eigen gegevens";

                var userId = (int) Session["userID"];
                var results = db.UserInfoes.Where(ui => ui.UserUserID == userId).First();
                var model = results;           
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult EigenGegevensWijzigen()
        {
                return View(EigenGegevens);
        }
      

        [HttpPost]
        public ActionResult Wijzigen(UserInfo UserInfo)
        {
            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                var result = db.UserInfoes.First();
                db.SaveChanges();            
            }

            return RedirectToAction("EigenGegevens", "Home");
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