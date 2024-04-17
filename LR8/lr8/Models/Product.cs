namespace lr8.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public required string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime ProductCreatedDate { get; set; }
    }
}
