using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace asprs3.Models
{
    public class Activity
    {
        [Key]
        public int FieldTrip_Id { get; set; }

        [Required]
        [Display(Name = "Class Id")]
        public string Teacher_Id { get; set; }//---Changed to string
                                              // [ForeignKey("Class_Id"), Column(Order = 1)]
        //[ForeignKey("Teacher_Id")]
        //public virtual Teacher Teacher { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Must enter a Activity Name", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Activity Name")]
        public string ActivityName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Submit By Date")]
        public DateTime? SubmitByDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Activity Date")]
        public DateTime? ActivityDate { get; set; }


     
    }
}