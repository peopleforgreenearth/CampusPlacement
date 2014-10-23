using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CampusPlacement.ViewModels
{
    public class SkillSearchModel
    {
        [Key]
        public int Id { get; set; }
        public string Skills { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string City { get; set; }

        public  Models.Country Country { get; set; }
        public  Models.State State { get; set; }
       

    }
}