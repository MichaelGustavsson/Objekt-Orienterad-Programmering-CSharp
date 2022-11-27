namespace OrderManagement;

public class Product : IProduct
{
    public Guid ProductId { get; set; }
    public string ItemNumber { get; init; }
    public decimal Price { get; set; }
    public bool IsInStock { get; set; }

    public Product(string itemNumber)
    {
        ItemNumber = itemNumber;
    }
    public virtual IProduct Find(string itemNumber)
    {
        throw new NotImplementedException();
    }
    public virtual List<IProduct> ListAllProducts()
    {
        throw new NotImplementedException();
    }
    public virtual bool Save()
    {
        throw new NotImplementedException();
    }
}