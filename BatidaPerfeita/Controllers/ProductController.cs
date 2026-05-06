using BatidaPerfeita.Models;
using BatidaPerfeita.Models.ViewModels;
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
        private readonly IProductRepository _productRepository;

        public ProductController(IProductService productService, IProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? categoryName, [FromQuery] PaginationParameters parameters)
        {
            var viewModel = await _productService
                .GetProductsAsync(categoryName, parameters);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int productId)
        {
            var product = await _productRepository.GetProductByIdAsync(productId);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchString)
        {
            var products = await _productRepository.GetAllProductsAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p =>
                p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                p.ShortDescription.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var productsVM = new ProductListViewModel
            {
                Products = products
            };

            return View("Index", productsVM);
        }
    }
}
