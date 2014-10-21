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
        public virtual Models.Country Country { get; set; }
        public virtual Models.State State { get; set; }
        public string City { get; set; }

    }
}