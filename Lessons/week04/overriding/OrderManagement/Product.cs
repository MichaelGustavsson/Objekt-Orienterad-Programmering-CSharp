namespace OrderManagement;

public class Product
{
    // Properties...
    public Guid ProductId { get; set; } = Guid.NewGuid();
    public string ItemNumber { get; init; }
    public Decimal Price { get; set; }
    public bool IsInStock { get; set; }

    // Constructors...
    public Product(string itemNumber)
    {
        ItemNumber = itemNumber;
        // Här kommer det att finnas logik för att hämta en produkt
        // med angivet artikelnummer...
    }
    // Methods...
    public virtual bool Save()
    {
        Console.WriteLine("Sparar produkt.");
        return true;
    }
    public Product Find(string itemNumber)
    {
        return new Product(itemNumber);
    }
    public List<Product> ListAllProducts()
    {
        return new List<Product>();
    }

    // public override string ToString()
    // {
    //     return $"ProductId: {ProductId}";
    // }
}