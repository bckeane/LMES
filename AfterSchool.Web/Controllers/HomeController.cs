using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AfterSchool.Core;
using AfterSchool.Web.Infrastructure;

namespace AfterSchool.Web.Controllers
{
    public class HomeController : Controller
    {

        private iEnrollment _db; // = new ClubDb();

        public HomeController(iEnrollment db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allClubs = _db.Clubs;
            return View(allClubs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}