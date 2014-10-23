using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusPlacement.ViewModels
{
    public class JobPostingDetailsModel
    {
        public int PostingId { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string CountryName { get; set; }
        public string Department { get; set; }
        public string JobDescription { get; set; }
        public string EducationLevelName { get; set; }
        public string JobCode { get; set; }
        public string JobTypeName { get; set; }
        public decimal MaxSalary { get; set; }
        public decimal MinSalary { get; set; }
        public DateTime PostingDate { get; set; }
        public string StateName { get; set; }
        public string Title { get; set; }

    }
}