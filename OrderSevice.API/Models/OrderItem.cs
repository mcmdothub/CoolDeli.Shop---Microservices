﻿using System;

namespace OrderSevice.API.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
