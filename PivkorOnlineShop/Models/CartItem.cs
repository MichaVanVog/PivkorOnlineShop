using System;

namespace PivkorOnlineShop.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public decimal AmountPriceOfProduct
        {
            get
            {
                return Product.Price * Amount;
            }
        }
    }
}