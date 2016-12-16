using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace asprs3.Models
{
    public class Guardianship
    {
        [Key]
        [Required]
        public int Guardianship_Id { get; set; }

        [Required]
        public string UserName { get; set; }
        [ForeignKey("UserName"), Column(Order = 1)]
        public virtual ApplicationUser Parent { get; set; }

        [Required]
        public int Student_Number { get; set; }
        [ForeignKey("Student_Number"), Column(Order = 2)]
        public virtual Student Student { get; set; }
    }
}