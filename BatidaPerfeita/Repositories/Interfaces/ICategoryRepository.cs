using BatidaPerfeita.Models;

namespace BatidaPerfeita.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
