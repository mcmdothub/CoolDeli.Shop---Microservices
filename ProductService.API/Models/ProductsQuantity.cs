using System;

namespace ProductService.API.Models
{
    public class ProductsQuantity
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
