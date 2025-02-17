using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OverAnalysisApp.Models
{
    public enum DeliveryType
    {
        Legal,
        Wide,
        NoBall
    }
    public class Over
    {
        [Key]
        public int Id { get; set; }

        [Range(1,10,ErrorMessage = "Minimum 1 and maximum 10 overs allowed per bowler")]
        [Required(ErrorMessage = "The OverNumber field is required.")]
        public int OverNumber { get; set; }

        [Required(ErrorMessage = "The BallNo field is required.")]
        [Range(1,int.MaxValue,ErrorMessage ="Ball no must be greater than 0")]
        public int BallNo { get; set; }

        [StringLength(25)]
        [Column(TypeName ="varchar")]
        [Required(ErrorMessage = "Bowler names is required.")]
        public string BowlerName { get; set; }

        [Required]
        public DeliveryType DeliveryTypes { get; set; }

        [Required(ErrorMessage = "The Runs field is required.")]
        [RegularExpression("^[0-9][0-9]*$", ErrorMessage ="Only 0 or more runs are allowed per ball")]
        public int Runs { get; set; }

        [Required]
        [Column(TypeName ="bit")]
        public bool IsWicketTaken { get; set; }
    }
}
