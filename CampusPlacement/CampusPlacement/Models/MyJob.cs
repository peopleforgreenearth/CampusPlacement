using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class MyJob
    {
        public int MyJobID { get; set; }
        public Nullable<int> PostingID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
