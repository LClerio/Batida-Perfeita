using BatidaPerfeita.Models;
using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatidaPerfeita.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartRepository _cartRepository;

        public CartController(IProductRepository productRepository,
                              ICartRepository cartRepository)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            var cartId = GetOrCreateCartId();
            var items = _cartRepository.GetCartItems(cartId);

            var cartViewModel = new CartViewModel
            {
                Cart = new Cart
                {
                    CartId = cartId,
                    CartItems = items
                },
                CartTotal = _cartRepository.GetCartTotal(cartId)
            };

            return View(cartViewModel);
        }

        public async Task<IActionResult> AddToCart(int productId)
        {
            var selectedProduct = await _productRepository.GetProductByIdAsync(productId);

            if (selectedProduct != null)
            {
                var cartId = GetOrCreateCartId();
                _cartRepository.AddToCart(selectedProduct, cartId);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            var selectedProduct = await _productRepository.GetProductByIdAsync(productId);

            if (selectedProduct != null)
            {
                var cartId = GetOrCreateCartId();
                _cartRepository.RemoveFromCart(selectedProduct, cartId);
            }

            return RedirectToAction("Index");
        }

        public IActionResult ClearCart()
        {
            var cartId = GetOrCreateCartId();
            _cartRepository.ClearCart(cartId);

            return RedirectToAction("Index");
        }

        private string GetOrCreateCartId()
        {
            var session = HttpContext.Session;
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return cartId;
        }
    }
}
