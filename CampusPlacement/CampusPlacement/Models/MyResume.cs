using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class MyResume
    {
        public int MyResumeID { get; set; }
        public Nullable<int> ResumeID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
