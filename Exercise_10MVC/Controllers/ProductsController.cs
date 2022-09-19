using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercise_9.Entity;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace Exercise_9.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration _config;
        private readonly string _apiUri;
        
       

        public ProductsController(IConfiguration config)
        {
            _config = config;
            _apiUri = _config.GetValue<string>("WebApiUrl");
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            IList<Product> product = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_apiUri);
                    //HTTP GET
                    var responseTask = client.GetAsync("products");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Product>>();
                        readTask.Wait();
                       
                        product = readTask.Result;
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Application Error");
            }
            return View(product);
        }
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                Product product = ProductExists(id.Value);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Image,Name,ItemNumber,ShortDescription,FullDescription,Price,Caliber,Movement,Chronograph,Weight,Height,Diameter,Thickness,Jewely,CaseMaterial,StrapMaterial")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_apiUri);
                        var responseTask = client.PostAsJsonAsync("products", product);
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
            }
            catch
            {
                return BadRequest();
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = ProductExists(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Image,Name,ItemNumber,ShortDescription,FullDescription,Price,Caliber,Movement,Chronograph,Weight,Height,Diameter,Thickness,Jewely,CaseMaterial,StrapMaterial")] Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_apiUri);
                        //HTTP GET
                        var responseTask = client.PutAsJsonAsync($"products/{id}", product);
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                }
            }
            catch
            {
                return BadRequest("Application Error");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = ProductExists(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)       
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_apiUri);
                    //HTTP GET
                    var responseTask = client.DeleteAsync($"products/{id}");
                    responseTask.Wait();
                   
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                return View();
            }
            catch (Exception)
            {
                return BadRequest("Application Error");
            }          
        }
       
        private Product ProductExists(int id)
        {
            Product product = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiUri);
                //HTTP GET
                var responseTask = client.GetAsync($"products/{id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Product>();
                    readTask.Wait();

                    product = readTask.Result;
                }
                else
                {
                    return null;
                }
            }
            return product;
        }
    }
}
