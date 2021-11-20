using System.Collections.Generic;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop
{
    public interface IProductsInMemoryRepository
    {
        List<Product> GetProducts();
        Product TryGetById(int id);
        void Add(Product product);
        void Update(Product product);
    }
}