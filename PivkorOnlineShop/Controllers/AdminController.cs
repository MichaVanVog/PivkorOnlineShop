using Microsoft.AspNetCore.Mvc;
using System;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsInMemoryRepository productsInMemoryRepository;
        private readonly IOrdersInMemoryRepository ordersInMemoryRepository;
        private readonly IRolesInMemoryRepository rolesInMemoryRepository;

        public AdminController(IProductsInMemoryRepository productsInMemoryRepository, IOrdersInMemoryRepository ordersInMemoryRepository, IRolesInMemoryRepository rolesInMemoryRepository)
        {
            this.productsInMemoryRepository = productsInMemoryRepository;
            this.ordersInMemoryRepository = ordersInMemoryRepository;
            this.rolesInMemoryRepository = rolesInMemoryRepository;
        }

        public IActionResult Orders()
        {
            var orders = ordersInMemoryRepository.GetAllOrders();
            return View(orders);
        }

        public IActionResult OrderDetails(Guid orderId)
        {
            var order = ordersInMemoryRepository.TryGetById(orderId);
            return View(order);
        }

        public IActionResult UpdateOrderStatus(Guid orderId, OrderStatus orderStatus)
        {
            ordersInMemoryRepository.UpdateOrderStatus(orderId, orderStatus);
            return RedirectToAction("Orders");
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            var roles = rolesInMemoryRepository.GetAllRoles();
            return View(roles);
        }

        public IActionResult RemoveRole(string roleName)
        {
            rolesInMemoryRepository.Remove(roleName);
            return RedirectToAction("Roles");
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            if (rolesInMemoryRepository.TryGetByName(role.Name) != null)
            {
                ModelState.AddModelError("", "Роль с таким названием уже существует");
            }
            if (ModelState.IsValid)
            {
                rolesInMemoryRepository.Add(role);
                return RedirectToAction("Roles");
            }
            return View(role);
        }

        public IActionResult Products()
        {
            var products = productsInMemoryRepository.GetProducts();
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            productsInMemoryRepository.Add(product);
            return RedirectToAction("Products");
        }

        public IActionResult EditProduct(int productId)
        {
            var product = productsInMemoryRepository.TryGetById(productId);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            productsInMemoryRepository.Update(product);
            return RedirectToAction("Products");
        }
    }
}
