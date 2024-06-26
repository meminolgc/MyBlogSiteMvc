﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSiteMvc.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            var categoryValues = cm.GetAll();
            return View(categoryValues);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = cm.GetAll();
            return PartialView(categoryValues);
        }

        public ActionResult AdminCategoryList()
        {
            var categoryList = cm.GetAll();
            return View(categoryList);
        }
    }
}