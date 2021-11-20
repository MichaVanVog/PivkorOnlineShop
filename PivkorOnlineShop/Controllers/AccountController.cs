using Microsoft.AspNetCore.Mvc;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Delivery", "Home");
            }
            return RedirectToAction("Login");
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            if (registration.Phone.ToString() == registration.Password)
            {
                ModelState.AddModelError("", "логин и пароль не должны совпадать");
            }
            if (registration.FirstName == registration.Password)
            {
                ModelState.AddModelError("", "имя и пароль не должны совпадать");
            }
            if (registration.LastName == registration.Password)
            {
                ModelState.AddModelError("", "фамилия и пароль не должны совпадать");
            }
            if (registration.Email == registration.Password)
            {
                ModelState.AddModelError("", "адрес электронной почты и пароль не должны совпадать");
            }
            if (registration.Patronymic == registration.Password)
            {
                ModelState.AddModelError("", "отчество и пароль не должны совпадать");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Delivery", "Home");
            }
            return RedirectToAction("Registration");
        }
    }
}
