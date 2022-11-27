namespace OrderManagement;

public class Product
{
    // Properties(Egenskaper)...
    public Guid ProductId { get; set; } = Guid.NewGuid();
    public string ItemNumber { get; set; } = "";
    public Decimal Price { get; set; }
    public bool IsInStock { get; set; }

    // Methods(Metoder/Beteende)...
    public bool Save()
    {
        return true;
    }
    public Product Find(string itemNumber)
    {
        return new Product();
    }
    public List<Product> ListAllProducts()
    {
        return new List<Product>();
    }
}