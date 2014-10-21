using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class Resume
    {
        public int ResumeID { get; set; }
        public string UserName { get; set; }
        public string JobTitle { get; set; }
        public string TargetCity { get; set; }
        public int TargetStateID { get; set; }
        public int TargetCountryID { get; set; }
        public int RelocationCountryID { get; set; }
        public int TargetJobTypeID { get; set; }
        public int EducationLevelID { get; set; }
        public int ExperienceLevelID { get; set; }
        public string ResumeText { get; set; }
        public string CoverLetterText { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> SubcategoryID { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public virtual Country Country { get; set; }
        public virtual EducationLevel EducationLevel { get; set; }
        public virtual ExperienceLevel ExperienceLevel { get; set; }
        public virtual JobType JobType { get; set; }
    }
}
