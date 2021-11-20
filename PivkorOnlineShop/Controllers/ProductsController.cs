using Microsoft.AspNetCore.Mvc;

namespace PivkorOnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsInMemoryRepository productsInMemoryRepository;

        public ProductsController(IProductsInMemoryRepository productsInMemoryRepository)
        {
            this.productsInMemoryRepository = productsInMemoryRepository;
        }

        public IActionResult Index(int id)
        {
            var product = productsInMemoryRepository.TryGetById(id);
            return View(product);
        }
    }
}
