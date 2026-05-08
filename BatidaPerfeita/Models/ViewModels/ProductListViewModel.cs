using Microsoft.AspNetCore.Mvc.Rendering;

namespace BatidaPerfeita.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public string CurrentCategory { get; set; } = string.Empty;
        public string SelectCategory { get; set; } = string.Empty;
        public string SortOrder { get; set; }

        public IEnumerable<SelectListItem> SortOptions { get; set; }

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        public int TotalPages => PageSize > 0
            ? (int)Math.Ceiling((double)TotalItems / PageSize) : 1;


    }
}
