﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("WeatherOrNot");
        }
        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public ActionResult WeatherIP()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Weather wthr = new Weather();
            return Json(wthr.getWeatherForecast(),JsonRequestBehavior.AllowGet);
        }

        
    }
}