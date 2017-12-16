using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Scripts;

namespace WebApplication1.Controllers
{
    public class table2Controller : Controller
    {
        private comp2084asg1 db = new comp2084asg1();

        // GET: table2
        public ActionResult Index()
        {
            return View(db.table2.ToList());
        }

        // GET: table2/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2 table2 = db.table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // GET: table2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: table2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "topings,subs,size")] table2 table2)
        {
            if (ModelState.IsValid)
            {
                db.table2.Add(table2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table2);
        }

        // GET: table2/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2 table2 = db.table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // POST: table2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "topings,subs,size")] table2 table2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table2);
        }

        // GET: table2/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2 table2 = db.table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // POST: table2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            table2 table2 = db.table2.Find(id);
            db.table2.Remove(table2);
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
