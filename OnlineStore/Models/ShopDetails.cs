namespace OnlineStore.Models
{
    public class ShopDetails
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string? Category { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
    }
}