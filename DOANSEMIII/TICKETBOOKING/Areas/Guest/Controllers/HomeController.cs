﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TICKETBOOKING.Areas.Guest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Guest/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Demo()
        {
            return View();
        }
    }
}