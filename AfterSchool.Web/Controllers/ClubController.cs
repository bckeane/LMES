using AfterSchool.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfterSchool.Web.Controllers
{
    public class ClubController : Controller
    {

        private readonly iEnrollment _db;

        public ClubController(iEnrollment db)
        {
            _db = db;
        }

        //
        // GET: /Club/
        public ActionResult Detail(int id)
        {
            var model = _db.Clubs.Single(c => c.ID == id);
            return View(model);
        }
	}
}