using BatidaPerfeita.Context;
using BatidaPerfeita.Models;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BatidaPerfeita.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
    
            public ProductRepository(AppDbContext context)
            {
                _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(c=> c.Category)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetPreferredProductAsync()
        {
            return await _context.Products
                .Where(p=> p.IsPreferredProduct)
                .Include(p => p.Category)
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Product?> GetProductByIdAsync(int Id)
        {
            return _context.Products.FirstOrDefaultAsync(p => p.ProductId == Id);
        }
    }
}
