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
    public class EducationLevelController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /EducationLevel/
        public ActionResult Index()
        {
            return View(db.EducationLevels.ToList());
        }

        // GET: /EducationLevel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationLevel educationlevel = db.EducationLevels.Find(id);
            if (educationlevel == null)
            {
                return HttpNotFound();
            }
            return View(educationlevel);
        }

        // GET: /EducationLevel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /EducationLevel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EducationLevelID,EducationLevelName")] EducationLevel educationlevel)
        {
            if (ModelState.IsValid)
            {
                db.EducationLevels.Add(educationlevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(educationlevel);
        }

        // GET: /EducationLevel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationLevel educationlevel = db.EducationLevels.Find(id);
            if (educationlevel == null)
            {
                return HttpNotFound();
            }
            return View(educationlevel);
        }

        // POST: /EducationLevel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EducationLevelID,EducationLevelName")] EducationLevel educationlevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(educationlevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(educationlevel);
        }

        // GET: /EducationLevel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationLevel educationlevel = db.EducationLevels.Find(id);
            if (educationlevel == null)
            {
                return HttpNotFound();
            }
            return View(educationlevel);
        }

        // POST: /EducationLevel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EducationLevel educationlevel = db.EducationLevels.Find(id);
            db.EducationLevels.Remove(educationlevel);
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
