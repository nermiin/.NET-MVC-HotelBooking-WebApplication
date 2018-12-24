using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MACARENA;
using MACARENA.Models;

namespace MACARENA.Controllers
{
    public class RezervationsController : Controller
    {
        private MacarenaDBContext db = new MacarenaDBContext();

        // GET: Rezervations
        public ActionResult Index()
        {
            return View(db.Rezervations.ToList());
        }

        // GET: Rezervations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervation rezervation = db.Rezervations.Find(id);
            if (rezervation == null)
            {
                return HttpNotFound();
            }
            return View(rezervation);
        }

        // GET: Rezervations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rezervations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezervationId,RoomName,CheckInDate,CheckOutDate,AdultNumber,ChildrenNumber")] Rezervation rezervation)
        {
            if (ModelState.IsValid)
            {
                db.Rezervations.Add(rezervation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rezervation);
        }

        // GET: Rezervations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervation rezervation = db.Rezervations.Find(id);
            if (rezervation == null)
            {
                return HttpNotFound();
            }
            return View(rezervation);
        }

        // POST: Rezervations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezervationId,RoomName,CheckInDate,CheckOutDate,AdultNumber,ChildrenNumber")] Rezervation rezervation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rezervation);
        }

        // GET: Rezervations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervation rezervation = db.Rezervations.Find(id);
            if (rezervation == null)
            {
                return HttpNotFound();
            }
            return View(rezervation);
        }

        // POST: Rezervations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rezervation rezervation = db.Rezervations.Find(id);
            db.Rezervations.Remove(rezervation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
