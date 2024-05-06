using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace MyBlogSiteMvc.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager();

        public ActionResult Index()
        {
            var aboutcontent = abm.GetAll();
            return View(aboutcontent);
        }

        public PartialViewResult Footer()
        {
            var aboutContentList = abm.GetAll();
            return PartialView(aboutContentList);
        }

        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}