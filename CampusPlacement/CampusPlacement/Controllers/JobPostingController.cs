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
    public class JobPostingController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /JobPosting/
        public ActionResult Index()
        {
            return View(db.JobPostings.ToList());
        }

        // GET: /JobPosting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobPosting jobposting = db.JobPostings.Find(id);
            if (jobposting == null)
            {
                return HttpNotFound();
            }
            return View(jobposting);
        }

        // GET: /JobPosting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /JobPosting/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PostingID,CompanyID,ContactPerson,Title,Department,JobCode,City,StateID,CountryID,EducationLevelID,JobTypeID,MinSalary,MaxSalary,JobDescription,PostingDate,PostedBy")] JobPosting jobposting)
        {
            if (ModelState.IsValid)
            {
                db.JobPostings.Add(jobposting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobposting);
        }

        // GET: /JobPosting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobPosting jobposting = db.JobPostings.Find(id);
            if (jobposting == null)
            {
                return HttpNotFound();
            }
            return View(jobposting);
        }

        // POST: /JobPosting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PostingID,CompanyID,ContactPerson,Title,Department,JobCode,City,StateID,CountryID,EducationLevelID,JobTypeID,MinSalary,MaxSalary,JobDescription,PostingDate,PostedBy")] JobPosting jobposting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobposting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobposting);
        }

        // GET: /JobPosting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobPosting jobposting = db.JobPostings.Find(id);
            if (jobposting == null)
            {
                return HttpNotFound();
            }
            return View(jobposting);
        }

        // POST: /JobPosting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobPosting jobposting = db.JobPostings.Find(id);
            db.JobPostings.Remove(jobposting);
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
