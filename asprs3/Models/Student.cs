using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprs3.Models
{
    public class Student
    {
        [Key]
        [Column(Order = 2)]
        [Display(Name = "Student Number")]
        public int Student_Number { get; set; }

        [Required]
        [Display(Name = "Student First Name")]
        public String Stud_F_Name { get; set; }

        [Required]
        [Display(Name = "Student Last Name")]
        public String Stud_L_Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Date_Of_Birth { get; set; }
    }
}