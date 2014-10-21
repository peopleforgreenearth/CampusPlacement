using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            this.JobPostings = new List<JobPosting>();
            this.Resumes = new List<Resume>();
        }

        public int EducationLevelID { get; set; }
        public string EducationLevelName { get; set; }
        public virtual ICollection<JobPosting> JobPostings { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
