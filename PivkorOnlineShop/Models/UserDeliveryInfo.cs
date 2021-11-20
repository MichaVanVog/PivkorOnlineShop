using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public class UserDeliveryInfo
    {
        [Required(ErrorMessage = "Введите Ваше имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите номер Вашего телефона")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Введите улицу")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Введите номер дома")]
        public string HouseNumber { get; set; }
        public string Entrance { get; set; }
        public string Floor { get; set; }
        public string Flat { get; set; }
        public string Comments { get; set; }

        public UserDeliveryInfo()
        {

        }
    }
}
