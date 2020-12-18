using ProductService.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.API.Repositories
{
    public interface IProductsRepository
    {
        public Task<Product> GetProductByIdAsync(Guid id);
        public Task<bool> ProductExistAsync(Guid id);
        public Task<List<Product>> GetAllProductsAsync();
        public Task<int> CountAllProductsAsync(string search = null);
        public Task<List<Product>> GetPaginatedProductsAsync(int currentPage, int productsPerPage, string search = null);
        public Task<Product> AddProductAsync(Product product);
        public Task<bool> UpdateProductAsync(Product product);
        public Task<bool> UpdateProductsInStockAsync(IEnumerable<ProductsQuantity> orderedItems);
        public Task<bool> DeleteProductAsync(Guid id);
    }
}