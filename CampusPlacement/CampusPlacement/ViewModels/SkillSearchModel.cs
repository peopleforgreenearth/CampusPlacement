using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusPlacement.ViewModels
{
    public class SkillSearchModel
    {
        public string Skills { get; set; }
        public List<Models.Country> Country { get; set; }
        public List<Models.State> State { get; set; }
    }
}