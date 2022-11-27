namespace OrderManagement;

public interface IProduct
{
    // Properties...
    Guid ProductId { get; set; }
    string ItemNumber { get; init; }
    Decimal Price { get; set; }
    bool IsInStock { get; set; }

    // Methods...
    bool Save();
    IProduct Find(string itemNumber);
    List<IProduct> ListAllProducts();
}