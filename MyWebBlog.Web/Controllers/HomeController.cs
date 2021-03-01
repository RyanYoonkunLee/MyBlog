﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebBlog.Data.Sql.Database.DataAccess;
using MyWebBlog.Web.Models;

namespace MyWebBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeDataAccess _home;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _home = new HomeDataAccess();
        }

        public IActionResult Index()
        {
            ViewBag.Databases = _home.GetDatabases();
            ViewBag.Languages = _home.GetLanguages();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
