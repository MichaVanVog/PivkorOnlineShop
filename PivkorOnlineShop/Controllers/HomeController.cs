using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsInMemoryRepository productsInMemoryRepository;

        public HomeController(IProductsInMemoryRepository productsInMemoryRepository)
        {
            this.productsInMemoryRepository = productsInMemoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            var products = productsInMemoryRepository.GetProducts();
            return View(products);
        }

        public IActionResult Adresses()
        {
            return View();
        }

        public IActionResult ShoppingCart()
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
