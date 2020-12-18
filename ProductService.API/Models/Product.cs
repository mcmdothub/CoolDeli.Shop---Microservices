using System;

namespace ProductService.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public string Photo { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
