﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraComplexa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // Post: Home
        [HttpPost]
        public ActionResult Index(string bt, string display)
        {
            return View();
        }
    }
}