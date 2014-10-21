using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class ExperienceLevel
    {
        public ExperienceLevel()
        {
            this.Resumes = new List<Resume>();
        }

        public int ExperienceLevelID { get; set; }
        public string ExperienceLevelName { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
