﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSiteMvc.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager();

        public ActionResult Index()
        {          
            return View();
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            cm.BLContactAdd(p);
            return View();
        }

        public ActionResult SendBox()
        {
            var messageList = cm.GetAll();
            return View(messageList);
        }

        public ActionResult MessageDetails(int id)
        {
            Contact contact = cm.GetContactDetails(id);
            return View(contact);
        }
    }
}