using System;
using System.Collections.Generic;

namespace CampusPlacement.Models
{
    public partial class MySearch
    {
        public int MySearchID { get; set; }
        public string SearchCriteria { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
    }
}
