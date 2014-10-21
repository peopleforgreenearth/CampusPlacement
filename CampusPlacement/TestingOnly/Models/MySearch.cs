using System;
using System.Collections.Generic;

namespace TestingOnly.Models
{
    public partial class MySearch
    {
        public int MySearchID { get; set; }
        public string SearchCriteria { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
    }
}
