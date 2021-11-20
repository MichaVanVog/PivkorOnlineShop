using Microsoft.AspNetCore.Mvc;

namespace PivkorOnlineShop.Views.Shared.View.CartView
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartsInMemoryRepository cartsInMemoryRepository;

        public CartViewComponent(ICartsInMemoryRepository cartsInMemoryRepository)
        {
            this.cartsInMemoryRepository = cartsInMemoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartsInMemoryRepository.TryGetByUserId(Constants.UserId);
            var productCounts = cart?.Amount ?? 0;
            ViewBag.PriceSumOfAllItems = cart?.PriceSumOfAllItems ?? 0;
            return View("Cart", productCounts);
        }
    }
}
