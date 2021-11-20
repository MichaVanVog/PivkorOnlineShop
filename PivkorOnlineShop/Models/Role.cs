using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public class Role
    {
        [Required(ErrorMessage ="Наименование роли обязательно!")]
        public string Name { get; set; }    
    }
}
