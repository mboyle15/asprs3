using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asprs3.Models
{
    public class ApplicationUser : IdentityUser
    {

        public String FirstName { get; set; }
        public String LastName { get; set; }
        //public String StudentFirstName { get; set; }
        //public String StudentLastName { get; set; }
        //public DateTime DateOfBirth { get; set; } 

    }
}