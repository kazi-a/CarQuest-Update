using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarQuest.Models;

namespace CarQuest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Index()
        {
            ViewBag.Name = "Kazi";
            ViewBag.FV = 0.00;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CarFinance model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateMonthlyPayment();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }

        public IActionResult Contact()
        {
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