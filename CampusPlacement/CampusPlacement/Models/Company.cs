using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class Company
    {
        public Company()
        {
            this.JobPostings = new List<JobPosting>();
        }

        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string CompanyEmail { get; set; }
        public string WebSiteUrl { get; set; }
        public string CompanyProfile { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<JobPosting> JobPostings { get; set; }
    }
}
