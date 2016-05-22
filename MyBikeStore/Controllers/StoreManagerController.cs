using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyBikeStore.Models;

namespace MyBikeStore.Controllers
{
    public class StoreManagerController : Controller
    {
        private MyBikeStoreEntities db = new MyBikeStoreEntities();

        // GET: StoreManager
        public ActionResult Index()
        {
            return View(db.Velosipedi.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Velosiped velosiped = db.Velosipedi.Find(id);
            if (velosiped == null)
            {
                return HttpNotFound();
            }
            return View(velosiped);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VelosipedID,Ime,Cena,VelosipedURL")] Velosiped velosiped)
        {
            if (ModelState.IsValid)
            {
                db.Velosipedi.Add(velosiped);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(velosiped);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Velosiped velosiped = db.Velosipedi.Find(id);
            if (velosiped == null)
            {
                return HttpNotFound();
            }
            return View(velosiped);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VelosipedID,Ime,Cena,VelosipedURL")] Velosiped velosiped)
        {
            if (ModelState.IsValid)
            {
                db.Entry(velosiped).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(velosiped);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Velosiped velosiped = db.Velosipedi.Find(id);
            if (velosiped == null)
            {
                return HttpNotFound();
            }
            return View(velosiped);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Velosiped velosiped = db.Velosipedi.Find(id);
            db.Velosipedi.Remove(velosiped);
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
