namespace OrderManagement;

public class OrderItem
{
    public int Quantity { get; set; }
    public string DiscountCode { get; set; } = "";
    public Product? Product { get; set; }
}