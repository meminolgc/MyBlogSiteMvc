using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSiteMvc.Controllers
{
    public class UserController : Controller
    {
        // GET: AuthorLogin
        public ActionResult Index()
        {
            return View();
        }
    }
}