﻿using BusinessLayer.Concrete;
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

        public PartialViewResult BlogList()
        {
            var blogList = bm.GetAll();
            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public PartialViewResult BlogCover()
        {
            return PartialView();
        }

        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }

        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}