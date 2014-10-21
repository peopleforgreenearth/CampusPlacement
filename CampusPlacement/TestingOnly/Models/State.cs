using System;
using System.Collections.Generic;

namespace TestingOnly.Models
{
    public partial class State
    {
        public State()
        {
            this.JobPostings = new List<JobPosting>();
        }

        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string StateName { get; set; }
        public virtual ICollection<JobPosting> JobPostings { get; set; }
    }
}
