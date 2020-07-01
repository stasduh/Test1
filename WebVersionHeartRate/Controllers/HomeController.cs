﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebVersionHeartRate.Models;

namespace WebVersionHeartRate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login");              
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}