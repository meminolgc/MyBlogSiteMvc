using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSiteMvc.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager bm = new BlogManager();

        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetail = bm.GetBlogByID(id);
            return PartialView(authorDetail);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogAuthorId = bm.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorBlogs = bm.GetBlogByAuthor(blogAuthorId);
            return PartialView(authorBlogs);
        }
    }
}