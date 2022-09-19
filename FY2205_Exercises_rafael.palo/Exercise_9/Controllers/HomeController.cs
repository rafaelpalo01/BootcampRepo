using Exercise_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Addtocart()
        {
            return View();
        }
        public IActionResult Applewatchseries7()
        {
            return View();
        }
        public IActionResult Galaxywatch()
        {
            return View();
        }
        public IActionResult Huawei()
        {
            return View();
        }
        public IActionResult Onepluswatch()
        {
            return View();
        }
        public IActionResult Stores()
        {
            return View();
        }
        public IActionResult Watches()
        {
            return View();
        }
        public IActionResult Xiaomi()
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
