using Microsoft.AspNetCore.Mvc;

namespace PivkorOnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductsInMemoryRepository productsRepository;
        private readonly ICartsInMemoryRepository cartsInMemoryRepository;

        public CartController(IProductsInMemoryRepository productsRepository, ICartsInMemoryRepository cartsInMemoryRepository)
        {
            this.productsRepository = productsRepository;
            this.cartsInMemoryRepository = cartsInMemoryRepository;
        }

        public IActionResult Index()
        {
            var cart = cartsInMemoryRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = productsRepository.TryGetById(productId);
            cartsInMemoryRepository.Add(product, Constants.UserId);
            return RedirectToAction("Delivery", "Home");
        }

        public IActionResult IcreaseItemsAmount(int productId)
        {
            var product = productsRepository.TryGetById(productId);
            cartsInMemoryRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseItemsAmount(int productId)
        {
            cartsInMemoryRepository.DecreaseItemsAmount(productId, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            cartsInMemoryRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}