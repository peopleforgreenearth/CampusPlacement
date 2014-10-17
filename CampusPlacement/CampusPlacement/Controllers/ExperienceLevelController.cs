using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampusPlacement.Models;

namespace CampusPlacement.Controllers
{
    public class ExperienceLevelController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /ExperienceLevel/
        public ActionResult Index()
        {
            return View(db.ExperienceLevels.ToList());
        }

        // GET: /ExperienceLevel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceLevel experiencelevel = db.ExperienceLevels.Find(id);
            if (experiencelevel == null)
            {
                return HttpNotFound();
            }
            return View(experiencelevel);
        }

        // GET: /ExperienceLevel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ExperienceLevel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ExperienceLevelID,ExperienceLevelName")] ExperienceLevel experiencelevel)
        {
            if (ModelState.IsValid)
            {
                db.ExperienceLevels.Add(experiencelevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experiencelevel);
        }

        // GET: /ExperienceLevel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceLevel experiencelevel = db.ExperienceLevels.Find(id);
            if (experiencelevel == null)
            {
                return HttpNotFound();
            }
            return View(experiencelevel);
        }

        // POST: /ExperienceLevel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ExperienceLevelID,ExperienceLevelName")] ExperienceLevel experiencelevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experiencelevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experiencelevel);
        }

        // GET: /ExperienceLevel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExperienceLevel experiencelevel = db.ExperienceLevels.Find(id);
            if (experiencelevel == null)
            {
                return HttpNotFound();
            }
            return View(experiencelevel);
        }

        // POST: /ExperienceLevel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExperienceLevel experiencelevel = db.ExperienceLevels.Find(id);
            db.ExperienceLevels.Remove(experiencelevel);
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
