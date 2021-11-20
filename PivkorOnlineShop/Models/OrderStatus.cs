using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public enum OrderStatus
    {
        [Display(Name ="Создан")]
        Created,
        [Display(Name = "Собран")]
        Processed,
        [Display(Name = "Отдан в доставку")]
        Delivering,
        [Display(Name = "Доставлен")]
        Delivered,
        [Display(Name = "Отменен")]
        Canceled
    }
}
