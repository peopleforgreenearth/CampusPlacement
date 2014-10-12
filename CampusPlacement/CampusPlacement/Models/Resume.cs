using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class Resume
    {
        public int ResumeID { get; set; }
        public string UserName { get; set; }
        public string JobTitle { get; set; }
        public string TargetCity { get; set; }
        public Nullable<int> TargetStateID { get; set; }
        public Nullable<int> TargetCountryID { get; set; }
        public Nullable<int> RelocationCountryID { get; set; }
        public Nullable<int> TargetJobTypeID { get; set; }
        public Nullable<int> EducationLevelID { get; set; }
        public Nullable<int> ExperienceLevelID { get; set; }
        public string ResumeText { get; set; }
        public string CoverLetterText { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> SubcategoryID { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
    }
}
