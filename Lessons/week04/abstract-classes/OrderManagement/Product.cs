namespace OrderManagement;

public abstract class Product
{
    // Properties...
    public abstract Guid ProductId { get; set; }
    public abstract string ItemNumber { get; init; }
    public abstract Decimal Price { get; set; }
    public abstract bool IsInStock { get; set; }


    // Methods...
    public abstract bool Save();
    public abstract Product Find(string itemNumber);
    public abstract List<Product> ListAllProducts();
}