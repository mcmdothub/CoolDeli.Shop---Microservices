using CoolDeli.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebMVC.Services
{
    public interface ICartService
    {
        public Task<bool> AddToCartAsync(Guid id);
        public Task<List<Cart>> GetCartItemsAsync();
        public Task RemoveOneItemAsync(Guid id);
        public Task DeleteItemAsync(Guid id);
        public void ClearCart();
    }
}
