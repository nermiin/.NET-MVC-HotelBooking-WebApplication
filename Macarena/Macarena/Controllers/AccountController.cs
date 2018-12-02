using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MACARENA.Models;

namespace MACARENA.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (OurDBContext db = new OurDBContext())
            {
                return View(db.UserAccount.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (OurDBContext db = new OurDBContext())
                {
                    db.UserAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + "     " + account.LastName + "Sucssesfuly registerd";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (OurDBContext db = new OurDBContext())
            {
                var usr = db.UserAccount.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserId"] = usr.UserID.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "User namse or password is wrong.");
                }
            }
                return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}