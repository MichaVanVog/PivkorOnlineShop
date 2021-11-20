using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Введите номер телефона")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль должен содержать минимум 6 знаков")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Повторите пароль")]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Введите Ваше имя")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Слишком короткое имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите Вашу фамилию")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Слишком короткая фамилия")]
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Введите адрес электронной почты")]
        [EmailAddress(ErrorMessage = "Введите адрес электронной почты в правильном формате")]
        public string Email { get; set; }
    }
}
