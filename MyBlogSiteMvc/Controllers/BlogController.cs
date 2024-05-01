using BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSiteMvc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = bm.GetAll().ToPagedList(page, 6);

            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPosts()
        {
            //1. Post
            var postTitle1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.blogDate1 = blogDate1;

            //2. Post
            var postTitle2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.blogDate2 = blogDate2;

            //3. Post
            var postTitle3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.blogDate3 = blogDate3;

            //4. Post
            var postTitle4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.blogDate4 = blogDate4;

            //5. Post
            var postTitle5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.blogDate5 = blogDate5;

            return PartialView();

        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {

            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var blogDetailsList = bm.GetBlogByID(id);
            return PartialView(blogDetailsList);
        }

        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailsList = bm.GetBlogByID(id);
            return PartialView(blogDetailsList);
        }

        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}