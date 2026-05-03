using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Pagination;

namespace BatidaPerfeita.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductListViewModel> GetProductsAsync(string categoriaName, PaginationParameters parameters);
    }
}
