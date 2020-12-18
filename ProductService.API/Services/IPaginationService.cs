using ProductService.API.Models;
using System.Threading.Tasks;

namespace ProductService.API.Services
{
    public interface IPaginationService
    {
        public Task<ProductPagination> GetPaginatedProductsAsync(int page = 1, string search = null);
    }
}
