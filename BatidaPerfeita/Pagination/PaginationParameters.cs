namespace BatidaPerfeita.Pagination
{
    public class PaginationParameters
    {
        private const int maxPageSize = 15;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 12;
        public int PageSize
        {
            get => pageSize;
            set => pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
    }
}
