using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberProfile()
        {
            return View();
        }

        public ActionResult Financial()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

    }
}