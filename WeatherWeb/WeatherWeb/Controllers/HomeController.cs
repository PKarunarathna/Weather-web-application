﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherWeb.Models;

namespace WeatherWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Weather");
        }

        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }


        public ActionResult WeatherByIP()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Weather weather = new Weather();
            return Json(weather.getWeatherForecast(),JsonRequestBehavior.AllowGet);
        }
    }
}