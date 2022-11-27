namespace OrderManagement;

public class Order
{
    public Guid OrderId { get; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public Decimal OrderValue { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
}