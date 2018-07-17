namespace StockApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public User UserId { get; set; }

    }
}
