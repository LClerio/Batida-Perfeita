using BatidaPerfeita.Models;

namespace BatidaPerfeita.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<IEnumerable<Product>> GetPreferredProductAsync();
        Task<Product?> GetProductByIdAsync(int Id);
    }
}
