using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult WhatIsViewTest()
        {
            ViewBag.Title = "Home Page";

            return ViewBag.Title();
        }
    }
}
