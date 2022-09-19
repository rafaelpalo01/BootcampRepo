using Exercise_9.Entity;
using Exercise_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercise_9.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly string _apiUri;

        public HomeController(IConfiguration config)
        {
           
            _config = config;
            _apiUri = _config.GetValue<string>("WebApiUrl");

        }

        public async Task<IActionResult> Index()
        {
            IList<Product> products = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_apiUri);
                    //HTTP GET
                    var responseTask = client.GetAsync("api/products");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Product>>();
                        readTask.Wait();

                        products = readTask.Result;
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Application Error");
            }
            return View(products);
            //var itemLists = await _context.ItemList.OrderByDescending(c => c.Id).Take(3).ToListAsync();
            //return View(itemLists);
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

        public IActionResult PageNotFound()
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
