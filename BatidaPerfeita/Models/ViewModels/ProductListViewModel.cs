namespace BatidaPerfeita.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public string CurrentCategory { get; set; } = string.Empty;
        public string SelectCategory { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);


    }
}
