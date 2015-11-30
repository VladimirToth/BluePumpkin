﻿using BluePumpkinn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BluePumpkinn.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles="Administrator")]
        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [RequireHttps]
        public ActionResult EventForm(EventsModels model)
        {
            return View(model);

        }

         
    }
}