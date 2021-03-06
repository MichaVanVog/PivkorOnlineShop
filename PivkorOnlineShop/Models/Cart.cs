using System;
using System.Collections.Generic;
using System.Linq;

namespace PivkorOnlineShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> Items { get; set; }

        public decimal PriceSumOfAllItems
        {
            get
            {
                return Items?.Sum(x => x.AmountPriceOfProduct) ?? 0;
            }
        }
        public decimal Amount
        {
            get
            {
                return Items?.Sum(x => x.Amount) ?? 0;
            }
        }
    }
}