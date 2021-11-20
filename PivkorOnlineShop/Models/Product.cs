using System;
using System.ComponentModel.DataAnnotations;

namespace PivkorOnlineShop.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; set; }
        [Required(ErrorMessage = "Наименование обязательно")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Цена продажи обязательна")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Product()
        {
            Id = instanceCounter;
            instanceCounter += 1;
        }

        public Product(string name, decimal price, string description, string imagePath):this()
        {
            Name = name;    
            Price = price;
            Description = description;
            ImagePath = imagePath;
        }
    }
}
