using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class Country
    {
        public Country()
        {
            this.Companies = new List<Company>();
            this.Resumes = new List<Resume>();
        }

        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
