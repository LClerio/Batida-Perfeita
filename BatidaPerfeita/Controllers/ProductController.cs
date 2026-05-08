using BatidaPerfeita.Models;
using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Pagination;
using BatidaPerfeita.Repositories.Interfaces;
using BatidaPerfeita.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Index(string? categoryName, string? sortOrder, [FromQuery] PaginationParameters parameters)
        {
            var viewModel = await _productService
                .GetProductsAsync(categoryName, parameters);

            // ordenação
            viewModel.Products = sortOrder switch
            {
                "price_asc" => viewModel.Products.OrderBy(p => p.Price),

                "price_desc" => viewModel.Products.OrderByDescending(p => p.Price),

                _ => viewModel.Products
            };

            // salva opção selecionada
            viewModel.SortOrder = sortOrder;

            // opções do select
            viewModel.SortOptions = new List<SelectListItem>
    {
        new SelectListItem
        {
            Value = "price_asc",
            Text = "MENOR PREÇO"
        },

        new SelectListItem
        {
            Value = "price_desc",
            Text = "MAIOR PREÇO"
        }
    };
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
