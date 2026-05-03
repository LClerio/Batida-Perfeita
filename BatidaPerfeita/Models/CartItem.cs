using System.ComponentModel.DataAnnotations;

namespace BatidaPerfeita.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        [StringLength(200)]
        public string CartId { get; set; }
    }
}
