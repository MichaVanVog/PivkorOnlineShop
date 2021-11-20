using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Введите номер телефона")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
