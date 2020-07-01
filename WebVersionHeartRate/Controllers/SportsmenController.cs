using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebVersionHeartRate.Models;

namespace WebVersionHeartRate.Controllers
{
    public class SportsmenController : Controller
    {
        private SportsmanContext db = new SportsmanContext();

        // GET: Sportsmen
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login");
            }
            return View(db.Sportsmen.ToList());
        }

        // GET: Sportsmen/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportsman sportsman = db.Sportsmen.Find(id);
            if (sportsman == null)
            {
                return HttpNotFound();
            }
            return View(sportsman);
        }

        // GET: Sportsmen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sportsmen/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "guid,formNumber,firstName,lastName")] Sportsman sportsman)
        {
            if (ModelState.IsValid)
            {
                sportsman.guid = Guid.NewGuid();
                db.Sportsmen.Add(sportsman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sportsman);
        }

        // GET: Sportsmen/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportsman sportsman = db.Sportsmen.Find(id);
            if (sportsman == null)
            {
                return HttpNotFound();
            }
            return View(sportsman);
        }

        // POST: Sportsmen/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "guid,formNumber,firstName,lastName")] Sportsman sportsman)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sportsman).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sportsman);
        }

        // GET: Sportsmen/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportsman sportsman = db.Sportsmen.Find(id);
            if (sportsman == null)
            {
                return HttpNotFound();
            }
            return View(sportsman);
        }

        // POST: Sportsmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Sportsman sportsman = db.Sportsmen.Find(id);
            db.Sportsmen.Remove(sportsman);
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
