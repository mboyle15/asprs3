using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asprs3.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Activity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public int Cost { get; set; }
        public int Capacity { get; set; }
        public string Eligible_Grades { get; set; }
        public string Offered_Days { get; set; }
        public int Quarter { get; set; }

    }
}