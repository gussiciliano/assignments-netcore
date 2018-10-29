using System;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories;
using AssignmentsNetcore.Repositories.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AssignmentsNetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _log;

        public HomeController(DbContextOptions<DataBaseContext> options, IHtmlLocalizer<HomeController> localizer, ILogger<HomeController> log)
        {
            this._localizer = localizer;
            this._log = log;
        }

        public IHtmlLocalizer<HomeController> Localizer
        {
            get { return this._localizer; }
        }

        public ILogger<HomeController> Log
        {
            get { return this._log; }
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
