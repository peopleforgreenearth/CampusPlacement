using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class MyResume
    {
        public int MyResumeID { get; set; }
        public int ResumeID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
