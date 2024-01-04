namespace BusinessLogicDemo.Models
{
    public class Supplier
    {
        public required int SupplierId {  get; set; }
        public required string SupplierName { get; set;}
        public string? Address {  get; set;}
        public string? Email { get; set;}
        public string? Phone { get; set;}
       
    }
}
