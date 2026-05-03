using BatidaPerfeita.Context;
using BatidaPerfeita.Models;
using BatidaPerfeita.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BatidaPerfeita.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _context;

        public CartRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddToCart(Product product, string cartId)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                s => s.Product.ProductId == product.ProductId && s.CartId == cartId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = cartId,
                    Product = product,
                    Quantity = 1
                };
                _context.CartItems.Add(cartItem);
            } else
            {
                cartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public int RemoveFromCart(Product product, string cartId)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                s => s.Product.ProductId == product.ProductId && s.CartId == cartId);

            int localQuantity = 0;

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    localQuantity = cartItem.Quantity;
                } else
                {
                    _context.CartItems.Remove(cartItem);
                }
            }

            _context.SaveChanges();
            return localQuantity;
        }

        public List<CartItem> GetCartItems(string cartId)
        {
            return _context.CartItems
                .Where(c => c.CartId == cartId)
                .Include(s => s.Product)
                .ToList();
        }

        public void ClearCart(string cartId)
        {
            var cartItems = _context.CartItems
                .Where(c => c.CartId == cartId);

            _context.CartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetCartTotal(string cartId)
        {
            return _context.CartItems
                .Where(c => c.CartId == cartId)
                .Include(c => c.Product)
                .AsEnumerable()
                .Sum(c => c.Product.Price * c.Quantity);

            //return _context.CartItems
            //    .Where(c => c.CartId == cartId)
            //    .Select(c => c.Product.Price * c.Quantity)
            //    .Sum();
        }
    }
}