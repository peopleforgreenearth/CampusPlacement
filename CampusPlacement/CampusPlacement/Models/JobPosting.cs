using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class JobPosting
    {
        public int PostingID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string ContactPerson { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string JobCode { get; set; }
        public string City { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> EducationLevelID { get; set; }
        public Nullable<int> JobTypeID { get; set; }
        public Nullable<decimal> MinSalary { get; set; }
        public Nullable<decimal> MaxSalary { get; set; }
        public string JobDescription { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public string PostedBy { get; set; }
    }
}
