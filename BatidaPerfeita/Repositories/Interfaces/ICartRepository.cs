using BatidaPerfeita.Models;

namespace BatidaPerfeita.Repositories.Interfaces
{
    public interface ICartRepository
    {
        void AddToCart(Product product, string cartId);
        int RemoveFromCart(Product product, string cartId);
        List<CartItem> GetCartItems(string cartId);
        void ClearCart(string cartId);
        decimal GetCartTotal(string cartId);
    }
}
