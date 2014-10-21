using System;
using System.Collections.Generic;

namespace TestingOnly.Models
{
    public partial class JobType
    {
        public JobType()
        {
            this.JobPostings = new List<JobPosting>();
            this.Resumes = new List<Resume>();
        }

        public int JobTypeID { get; set; }
        public string JobTypeName { get; set; }
        public virtual ICollection<JobPosting> JobPostings { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
