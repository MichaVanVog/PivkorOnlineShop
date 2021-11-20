using PivkorOnlineShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PivkorOnlineShop
{
    public class ProductsInMemoryRepository : IProductsInMemoryRepository
    {
        private List<Product> products = new()
        {
            new Product("Квас Рось", 89.90m, "безалкогольный", "/images/Spaten1.jpg"),
            new Product("Лимонад Дюшес", 79.90m, "сладкий", "/images/Spaten2.jpg"),
            new Product("Тархун", 79.90m, "безалкогольный", "/images/item_1701.jpg"),
            new Product("Медовуха темная", 189.90m, "гречичная", "/images/Медовуха.jpg"),
            new Product("Темная сторона Майнера", 129.99m, "темное, фильтрованное, непастеризованное", "/images/Spaten3.png"),
        };

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void Add(Product product)
        {
            product.ImagePath = "/images/Spaten1.jpg";
            products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = products.FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
        }
    }
}
