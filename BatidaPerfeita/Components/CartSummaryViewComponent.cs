using BatidaPerfeita.Models;
using BatidaPerfeita.Models.ViewModels;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatidaPerfeita.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly ICartRepository _cartRepository;

        public CartSummaryViewComponent(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cartId = HttpContext.Session.GetString("CartId");

            var items = string.IsNullOrEmpty(cartId)
                ? new List<CartItem>()
                : _cartRepository.GetCartItems(cartId);



            var cartVM = new CartViewModel
            {
                Cart = new Cart { CartItems = items },
                CartTotal = string.IsNullOrEmpty(cartId) ? 0 : _cartRepository.GetCartTotal(cartId)
            };

            return View(cartVM);
        }
    }
}
