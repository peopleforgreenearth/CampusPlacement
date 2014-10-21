using System;
using System.Collections.Generic;

namespace TestingOnly.Models
{
    public partial class JobPosting
    {
        public int PostingID { get; set; }
        public int CompanyID { get; set; }
        public string ContactPerson { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string JobCode { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public int EducationLevelID { get; set; }
        public int JobTypeID { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string JobDescription { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string PostedBy { get; set; }
        public virtual Company Company { get; set; }
        public virtual EducationLevel EducationLevel { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual State State { get; set; }
    }
}
