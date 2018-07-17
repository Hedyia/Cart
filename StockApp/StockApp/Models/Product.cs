namespace StockApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Qty { get; set; }
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public bool IsFavourite { get; set; }

    }
}
