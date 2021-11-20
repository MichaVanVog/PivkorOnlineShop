using Microsoft.AspNetCore.Mvc;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsInMemoryRepository cartsInMemoryRepository;
        private readonly IOrdersInMemoryRepository ordersInMemoryRepository;

        public OrderController(ICartsInMemoryRepository cartsInMemoryRepository, IOrdersInMemoryRepository ordersInMemoryRepository)
        {
            this.cartsInMemoryRepository = cartsInMemoryRepository;
            this.ordersInMemoryRepository = ordersInMemoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy(UserDeliveryInfo user)
        {
            if (ModelState.IsValid)
            {
                var existingCart = cartsInMemoryRepository.TryGetByUserId(Constants.UserId);
                var order = new Order
                {
                    User = user,
                    Items = existingCart.Items
                };
                ordersInMemoryRepository.Add(order);
                cartsInMemoryRepository.Clear(Constants.UserId);
                return View();
            }
            return RedirectToAction("Index", user);
        }
    }
}
