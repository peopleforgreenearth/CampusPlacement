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
    public class JobTypeController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /JobType/
        public ActionResult Index()
        {
            return View(db.JobTypes.ToList());
        }

        // GET: /JobType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobType jobtype = db.JobTypes.Find(id);
            if (jobtype == null)
            {
                return HttpNotFound();
            }
            return View(jobtype);
        }

        // GET: /JobType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /JobType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="JobTypeID,JobTypeName")] JobType jobtype)
        {
            if (ModelState.IsValid)
            {
                db.JobTypes.Add(jobtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobtype);
        }

        // GET: /JobType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobType jobtype = db.JobTypes.Find(id);
            if (jobtype == null)
            {
                return HttpNotFound();
            }
            return View(jobtype);
        }

        // POST: /JobType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="JobTypeID,JobTypeName")] JobType jobtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobtype);
        }

        // GET: /JobType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobType jobtype = db.JobTypes.Find(id);
            if (jobtype == null)
            {
                return HttpNotFound();
            }
            return View(jobtype);
        }

        // POST: /JobType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobType jobtype = db.JobTypes.Find(id);
            db.JobTypes.Remove(jobtype);
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
