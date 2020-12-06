using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiProjectTemplate.Models;
using System.Collections.Generic;
#if (service)
using MultiProjectTemplate.Service;
#endif
using System.Diagnostics;

namespace MultiProjectTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
#if (service)
        private ProductService productService = new ProductService();
#endif
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
#if (service)
            var products = productService.GetProducts();
#else
            var products = new List<string>()
            {
                "House",
                "Swimming pool",
                "Plane"
            };
#endif
            ViewBag.Products = products;
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
