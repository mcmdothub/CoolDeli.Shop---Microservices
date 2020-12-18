using OrderSevice.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderSevice.API.Repositories
{
    public interface IOrdersRepository
    {
        public Task<IEnumerable<Order>> GetAllOrdersAsync();
        public Task<Order> GetOrderByOrderIdAsync(Guid id);
        public Task<IEnumerable<Order>> GetOrdersByUserIdAsync(Guid id);
        public Task<Order> CreateOrderAsync(Order order);
        public Task<bool> UpdateOrderAsync(Order order);
        public Task<bool> DeleteOrderAsync(Guid id);
        public Task<bool> OrderExistAsync(Guid id);
    }
}
