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

        //Use-case "inzien en wijzigen eigengegevens "(Falco)
        public ActionResult EigenGegevens()
        {   //Geen usersession = redirect naar log-inscherm
            if (Session["userID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            
            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                //ID ophalen van ingelogde gebruiker
                var userId = (int) Session["userID"];

                //ID gebruiker vergelijken met opgeslagen userinfo en ophalen.
                var results = db.UserInfoes.Where(ui => ui.UserUserID == userId).First();
                var model = results;

                return View(model);
            }
        }
      
        //Use-case "Overzichten weergeven"(Stan)
        public ActionResult Classroom()
        {   
            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                //Data ophalen van database uit entiteit Classroom en doorsturen.
                var results = db.Classrooms.First();
                var model = results;
                return View(model);

            }
        }
       
        public ActionResult Teacher()
        {
            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                //Data ophalen van database uit entiteit Teachers en doorsturen.
                var results = db.Teachers.First();
                var model = results;
                return View(model);
            }
        }
        public ActionResult Education()
        {
            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                //Data ophalen van database uit entiteit Educations en doorsturen.
                var results = db.Educations.First();
                var model = results;
                return View(model);
            }
        }
        public ActionResult EigenGegevensWijzigen()
        {
            return View();
        }


        public ActionResult Overzicht()
        {
            return View();
        }
    }
}