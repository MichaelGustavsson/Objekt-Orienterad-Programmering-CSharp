namespace OrderManagement;

public class Shoe : Product
{
    // Properties...
    public string Brand { get; set; }
    public double Size { get; set; }
    public override Guid ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool IsInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string ItemNumber { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    public override decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // Constructors...
    public Shoe(string itemNumber)
    {
        Brand = "";
    }

    // Methods...
    public override bool Save()
    {
        Console.WriteLine("Sparar sko");
        return true;
    }

    public override Product Find(string itemNumber)
    {
        throw new NotImplementedException();
    }

    public override List<Product> ListAllProducts()
    {
        throw new NotImplementedException();
    }
}