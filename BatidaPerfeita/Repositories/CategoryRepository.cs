using BatidaPerfeita.Context;
using BatidaPerfeita.Models;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BatidaPerfeita.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
    
            public CategoryRepository(AppDbContext context)
            {
                _context = context;
            }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }
    }
}
