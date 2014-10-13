using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class Company
    {
        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string CompanyEmail { get; set; }
        public string WebSiteUrl { get; set; }
        public string CompanyProfile { get; set; }
    }
}
