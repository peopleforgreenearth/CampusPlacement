using System;
using System.Collections.Generic;

namespace TestingOnly.Models
{
    public partial class MyJob
    {
        public int MyJobID { get; set; }
        public int PostingID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
