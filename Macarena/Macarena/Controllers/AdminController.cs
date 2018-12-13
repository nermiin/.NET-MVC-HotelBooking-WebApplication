using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MACARENA.Models;

namespace MACARENA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
      public ActionResult CreatUser()
        {
            return View();
        }
        public ActionResult AssignRole()
        {
            return View();
        }
    }
}