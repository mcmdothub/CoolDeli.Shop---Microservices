﻿using System.Collections.Generic;

namespace ProductService.API.Models
{
    public class ProductPagination
    {
        public ProductPagination()
        {
            Products = new List<Product>();
        }

        public PaginationData PaginationData { get; set; }

        public List<Product> Products { get; set; }
    }


    public class PaginationData
    {
        public int PaginationLimit { get; set; }

        public int PaginationStart { get; set; }

        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public int TotalProducts { get; set; }
    }
}