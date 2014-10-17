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
    public class MySearchController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        // GET: /MySearch/
        public ActionResult Index()
        {
            return View(db.MySearches.ToList());
        }

        // GET: /MySearch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MySearch mysearch = db.MySearches.Find(id);
            if (mysearch == null)
            {
                return HttpNotFound();
            }
            return View(mysearch);
        }

        // GET: /MySearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MySearch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MySearchID,SearchCriteria,CountryID,StateID,City,UserName,PostDate")] MySearch mysearch)
        {
            if (ModelState.IsValid)
            {
                db.MySearches.Add(mysearch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mysearch);
        }

        // GET: /MySearch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MySearch mysearch = db.MySearches.Find(id);
            if (mysearch == null)
            {
                return HttpNotFound();
            }
            return View(mysearch);
        }

        // POST: /MySearch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MySearchID,SearchCriteria,CountryID,StateID,City,UserName,PostDate")] MySearch mysearch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mysearch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mysearch);
        }

        // GET: /MySearch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MySearch mysearch = db.MySearches.Find(id);
            if (mysearch == null)
            {
                return HttpNotFound();
            }
            return View(mysearch);
        }

        // POST: /MySearch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MySearch mysearch = db.MySearches.Find(id);
            db.MySearches.Remove(mysearch);
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
