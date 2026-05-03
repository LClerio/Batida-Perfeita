using BatidaPerfeita.Models;
using BatidaPerfeita.Pagination;
using BatidaPerfeita.Repositories.Interfaces;
using BatidaPerfeita.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BatidaPerfeita.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? categoryName, [FromQuery] PaginationParameters parameters)
        {
            var viewModel = await _productService
                .GetProductsAsync(categoryName, parameters);

            return View(viewModel);
        }
    }
}
