using Microsoft.AspNet.Identity;
using asprs3.Models;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;

namespace asprs3.Controllers
{
    public class ActivityController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Activity
        public ActionResult ActivityManager()
        {
            return View();
        }

       
    }
}