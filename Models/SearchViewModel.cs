using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OverAnalysisApp.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "Bowler names is required")]
        [StringLength(25)]
        public string BowlerName { get; set; }

        [Display(Name = "Delivery Type")]
        public DeliveryType DeliveryTypes { get; set; }
        public List<Over> OverDetails { get; set; }
    }
}
