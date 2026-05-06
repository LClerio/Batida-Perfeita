using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Repositories.Interfaces;

namespace BatidaPerfeita.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductRepository _productRepository;

    public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var products = await _productRepository.GetPreferredProductAsync();

        var productsVM = new ProductListViewModel
        {
            Products = products,
        };

        return View(productsVM);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
