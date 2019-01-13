using RoosterSysteem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoosterSysteem.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Inloggen        
        [HttpPost]
        public ActionResult Autherize(RoosterSysteem.Models.User userModel)
        {
            ViewBag.FoutieveInlog = false;

            using (ZuydDBEntities db = new ZuydDBEntities())
            {
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();

                //inloggegevens zijn onjuist > geef login pagina
                if (userDetails==null)
                {
                    return View("Index", userModel);
                }

                //inloggegevens zijn juist > Maak usersession en redirect naar homepage.
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["UserName"] = userDetails.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
            
        }

        //Uitloggen > Sessie afbreken
        public ActionResult LogOut()
        {
            int userID = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}