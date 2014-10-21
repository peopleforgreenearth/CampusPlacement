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

            return View();
        }

        [HttpPost]
        public ActionResult SearchJobs(CampusPlacement.ViewModels.SkillSearchModel model)
        {
            var results = from dt in db.JobPostings
                          //where dt.CountryID == model.Country.CountryID
                           // && dt.StateID == model.State.StateID
                          select dt;





            return View(results);
        }

	}
}