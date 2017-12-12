using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fitness.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Fitness.Areas.fitness.Controllers
{

    [Authorize(Roles = "admin")]
    public class FitnessController : Controller
    {
        ApplicationDbContext database = new ApplicationDbContext();

        public ActionResult List(string search, int? page)
        {
            var members = database.Users.Select(s => new Users
            {
                // UserId = s.Id,
                Name = s.UserName
            }).ToList();

            if (!String.IsNullOrEmpty(search))
            {
                members = members.Where(s => s.Name.Contains(search)).ToList();
            }
            members = members.OrderBy(x => x.Name).ToList();
            int pageSize = 7;
            int pageNumber = (page ?? 1);

            return View(members.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult DeleteProc(string ID)
        {
            var member = (from u in database.Users where u.Id == ID select u).FirstOrDefault();
            member memberInfo = new member();
            memberInfo.ID = member.Id;
            memberInfo.Name = member.UserName;
            return View(memberInfo);
        }

        [HttpPost, ActionName("DeleteProc")]
        public ActionResult Delete(string ID)
        {
            FitnessTrialEntities db = new FitnessTrialEntities();
            string user = (from v in database.Users where v.Id == ID select v.UserName).FirstOrDefault();
            int memberID = (from u in db.Users where u.Name == user select u.UserId).FirstOrDefault();

            var member = (from u in db.Users where u.UserId == ID select u).FirstOrDefault();
            if (member != null)
            {
                db.Users.Remove(member);
            }

            db.SaveChanges();

            var deleteMember = (from u in database.Users where u.Id == ID select u).FirstOrDefault();
            database.Users.Remove(deleteMember);
            database.SaveChanges();


            return RedirectToAction("List", "Members");
        }

        public ActionResult ChangeRole(string ID)
        {

            ChangeRole change = new ChangeRole();
            change.ID = ID;
            ViewBag.userInfo = (from u in database.Users where u.UserName == ID select u.UserName).FirstOrDefault();
            return View(change);
        }

        [HttpPost]
        public ActionResult ChangeRole(ChangeRole change)
        {

            if (ModelState.IsValid)
            {

                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(database));

                UserManager.AddToRole(change.ID, change.roleID);

            }


            return RedirectToAction("Listele", "Uyeler");

        }


        public ActionResult Remove(string ID)
        {
            ChangeRole change = new ChangeRole();
            change.ID = ID;
            ViewBag.userInfo = (from u in database.Users where u.UserName == ID select u.UserName).FirstOrDefault();

            return View(change);
        }

        [HttpPost]
        public ActionResult Remove(ChangeRole change)
        {
            if (ModelState.IsValid)
            {

                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(database));

                UserManager.RemoveFromRole(change.ID, change.roleID);

            }


            return RedirectToAction("List", "Users");
        }

        public ActionResult Authority(string ID)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(database));

            var roles = UserManager.GetRoles(ID);
            string authority = "";
            foreach (string role in roles)
            {
                authority += "|";
                authority += role;
                authority += "|";
            }
            ViewBag.authority = authority;
            return View();
        }


    }

    internal class ChangeRole
    {
        public ChangeRole()
        {
        }
    }
}




        
    