﻿using System;
using System.Collections.Generic;

namespace OrderSevice.API.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
