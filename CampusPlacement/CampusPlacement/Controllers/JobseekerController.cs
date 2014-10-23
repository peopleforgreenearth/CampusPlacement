using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CampusPlacement.Models;

namespace CampusPlacement.Controllers
{
    public class JobseekerController : Controller
    {
        private CampusPlacementDBContext db = new CampusPlacementDBContext();

        //
        // GET: /Jobseeker/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.CountryID = new SelectList(db.Countries, "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateName");

            return View();
        }

        [HttpPost]
        public ActionResult SearchJobs(CampusPlacement.ViewModels.SkillSearchModel model)
        {
            var results = from dt in db.JobPostings
                          where dt.CountryID == model.CountryID
                           // && dt.StateID == model.State.StateID
                          select dt;

            //ViewBag.CountryID = new SelectList(db.Countries, "CountryID", "CountryName");
            //ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name");



            return View(results);
        }

        public ActionResult PostingDetail(int id)
        {


            var results = (from jobs in db.JobPostings.Where(q => q.PostingID.Equals( id))
                          join cmp in db.Companies on jobs.CompanyID equals cmp.CompanyID
                          join cntry in db.Countries on jobs.CountryID equals cntry.CountryID
                          join edulevel in db.EducationLevels on jobs.EducationLevelID equals edulevel.EducationLevelID
                          join jobtype in db.JobTypes on jobs.JobTypeID equals jobtype.JobTypeID
                          join state in db.States on jobs.StateID equals state.StateID
                         
                          select new
                          {
                              jobs.City,
                              cmp.CompanyName
                              ,
                              jobs.ContactPerson
                              ,
                              cntry.CountryName
                              ,
                              jobs.Department
                              ,
                              jobs.JobDescription
                              ,
                              edulevel.EducationLevelName
                              ,
                              jobs.JobCode
                              ,
                              jobtype.JobTypeName
                              ,
                              jobs.MaxSalary
                              ,
                              jobs.MinSalary
                              ,
                              jobs.PostingDate
                              ,
                              state.StateName
                              ,
                              jobs.Title
                          }).FirstOrDefault();

            ViewModels.JobPostingDetailsModel mod = new ViewModels.JobPostingDetailsModel();

            mod.JobCode = results.JobCode;
            mod.City = results.City;
            mod.CompanyName = results.CompanyName;
            mod.ContactPerson = results.ContactPerson;
            mod.CountryName = results.CountryName;
            mod.Department = results.Department;
            mod.JobDescription = results.JobDescription;
            mod.EducationLevelName = results.EducationLevelName;
            mod.JobTypeName = results.JobTypeName;
            mod.MaxSalary = results.MaxSalary;
            mod.MinSalary = results.MinSalary;
            mod.PostingDate = results.PostingDate;
            //mod.PostingId = results.p
            mod.StateName = results.StateName;
            mod.Title = results.Title;

           // ViewBag.jobModel = mod;


            //JobPosting
            //Company
            //Country
            //EducationLevel
            //JobType
            //State

            ViewBag.JobModel = mod;

            return View();
        }
	}
}