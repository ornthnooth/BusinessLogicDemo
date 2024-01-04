namespace BusinessLogicDemo.Models
{
    public class Product
    {
        public required int ProductID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<Supplier>? Supplier { get; set; }
    }
}
