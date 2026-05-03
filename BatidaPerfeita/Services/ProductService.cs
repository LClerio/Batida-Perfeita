using BatidaPerfeita.Context;
using BatidaPerfeita.Models;
using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Pagination;
using BatidaPerfeita.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BatidaPerfeita.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ProductListViewModel> GetProductsAsync(string CategoryName, PaginationParameters parameters)
        {
            var query = _context.Products.AsNoTracking().Include(p => p.Category).AsQueryable();

            // Filtro
            if (!string.IsNullOrEmpty(CategoryName))
            {
                query = query
                    .Where(x => x.Category.Name.ToLower() == CategoryName.ToLower());
            }

            // 🔃 Ordenação
            query = query.OrderBy(p => p.ProductId);

            // 📊 Total de itens
            var totalItems = await query.CountAsync();

            // 🛡 Garantir página válida
            var pageNumber = parameters.PageNumber < 1 ? 1 : parameters.PageNumber;

            // 📄 Paginação
            var products = await query
                .Skip((pageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();

            return new ProductListViewModel
            {
                Products = products,
                Categories = await _context.Categories.AsNoTracking().ToListAsync(),
                CurrentCategory = string.IsNullOrEmpty(CategoryName)
                ? "Todos os produtos"
                : CategoryName,

                SelectCategory = CategoryName,

                PageNumber = pageNumber,
                PageSize = parameters.PageSize,
                TotalItems = totalItems
            };
        }
    }
}
