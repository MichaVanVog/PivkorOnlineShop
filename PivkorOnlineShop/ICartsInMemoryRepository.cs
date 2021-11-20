using System;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop
{
    public interface ICartsInMemoryRepository
    {
        void Add(Product product, string userId);
        void Clear(string userId);
        void DecreaseItemsAmount(int productId, string userId);
        Cart TryGetByUserId(string userId);
    }
}