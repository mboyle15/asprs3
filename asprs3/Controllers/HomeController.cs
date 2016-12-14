using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asprs3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}