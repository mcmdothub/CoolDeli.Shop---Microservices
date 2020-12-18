using APIGateway.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIGateway.Services
{
    public interface IGenerateService
    {
        public Task UpdateStockInProductsApiAsync(IEnumerable<OrderItem> order);
        public Task<HttpResponseMessage> PostNewOrderToOrdersServiceApiAsync(Order order);
    }
}
