using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.Areas.signup.Controllers
{
    public class SignupController : Controller
    {
        // GET: signup/Signup
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Membership()
        {
            return View();
        }

        public ActionResult PersonelInformation()
        {
            return View();
        }

        public ActionResult Health()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }
    }
}