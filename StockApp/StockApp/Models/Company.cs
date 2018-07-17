namespace StockApp.Models
{
    using System.Collections.Generic;

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public List<Product> Products { get; set; }
    }
}
