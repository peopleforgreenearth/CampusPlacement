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
    public class MyJobController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /MyJob/
        public ActionResult Index()
        {
            return View(db.MyJobs.ToList());
        }

        // GET: /MyJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyJob myjob = db.MyJobs.Find(id);
            if (myjob == null)
            {
                return HttpNotFound();
            }
            return View(myjob);
        }

        // GET: /MyJob/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MyJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MyJobID,PostingID,UserName,CreatedDate")] MyJob myjob)
        {
            if (ModelState.IsValid)
            {
                db.MyJobs.Add(myjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myjob);
        }

        // GET: /MyJob/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyJob myjob = db.MyJobs.Find(id);
            if (myjob == null)
            {
                return HttpNotFound();
            }
            return View(myjob);
        }

        // POST: /MyJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MyJobID,PostingID,UserName,CreatedDate")] MyJob myjob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myjob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myjob);
        }

        // GET: /MyJob/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyJob myjob = db.MyJobs.Find(id);
            if (myjob == null)
            {
                return HttpNotFound();
            }
            return View(myjob);
        }

        // POST: /MyJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyJob myjob = db.MyJobs.Find(id);
            db.MyJobs.Remove(myjob);
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
