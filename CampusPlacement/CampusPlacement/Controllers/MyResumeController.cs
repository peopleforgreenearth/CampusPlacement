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
    public class MyResumeController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /MyResume/
        public ActionResult Index()
        {
            return View(db.MyResumes.ToList());
        }

        // GET: /MyResume/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyResume myresume = db.MyResumes.Find(id);
            if (myresume == null)
            {
                return HttpNotFound();
            }
            return View(myresume);
        }

        // GET: /MyResume/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MyResume/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MyResumeID,ResumeID,UserName,CreatedDate")] MyResume myresume)
        {
            if (ModelState.IsValid)
            {
                db.MyResumes.Add(myresume);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myresume);
        }

        // GET: /MyResume/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyResume myresume = db.MyResumes.Find(id);
            if (myresume == null)
            {
                return HttpNotFound();
            }
            return View(myresume);
        }

        // POST: /MyResume/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MyResumeID,ResumeID,UserName,CreatedDate")] MyResume myresume)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myresume).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myresume);
        }

        // GET: /MyResume/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyResume myresume = db.MyResumes.Find(id);
            if (myresume == null)
            {
                return HttpNotFound();
            }
            return View(myresume);
        }

        // POST: /MyResume/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyResume myresume = db.MyResumes.Find(id);
            db.MyResumes.Remove(myresume);
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
