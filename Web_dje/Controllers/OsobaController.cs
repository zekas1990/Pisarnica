using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_dje.Models;

namespace Web_dje.Controllers
{
    public class OsobaController : Controller
    {
        private EntitieOsoba db = new EntitieOsoba();

        // GET: Osoba
        public ActionResult Index()
        {
            return View(db.OSOBA.ToList());
        }

        // GET: Osoba/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OSOBA oSOBA = db.OSOBA.Find(id);
            if (oSOBA == null)
            {
                return HttpNotFound();
            }
            return View(oSOBA);
        }

        // GET: Osoba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Osoba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OIB,IME,PREZIME")] OSOBA oSOBA)
        {
            if (ModelState.IsValid)
            {
                db.OSOBA.Add(oSOBA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oSOBA);
        }

        // GET: Osoba/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OSOBA oSOBA = db.OSOBA.Find(id);
            if (oSOBA == null)
            {
                return HttpNotFound();
            }
            return View(oSOBA);
        }

        // POST: Osoba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OIB,IME,PREZIME")] OSOBA oSOBA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oSOBA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oSOBA);
        }

        // GET: Osoba/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OSOBA oSOBA = db.OSOBA.Find(id);
            if (oSOBA == null)
            {
                return HttpNotFound();
            }
            return View(oSOBA);
        }

        // POST: Osoba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OSOBA oSOBA = db.OSOBA.Find(id);
            db.OSOBA.Remove(oSOBA);
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
