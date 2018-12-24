using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MACARENA.Models;
using MACARENA.Migrations;

namespace MACARENA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        MacarenaDB macarenaContext = new MacarenaDB();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public virtual ICollection<CitiesController> Cities { get; set; }
        public virtual ICollection<HotelsController> Hotels { get; set; }
        public virtual ICollection<RoomsController> Rooms { get; set; }
        public virtual ICollection<RezervationsController> Rezervations { get; set; }


    }
}