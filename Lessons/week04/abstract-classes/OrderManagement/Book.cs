namespace OrderManagement;

public class Book : Product
{
    // Properties...
    public string ISBN { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; }
    public bool HasHardCover { get; set; } = false;
    public override Guid ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override bool IsInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string ItemNumber { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    public override decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    // Constructors...
    public Book(string itemNumber)
    {
    }

    // Methods...
    public override bool Save()
    {
        Console.WriteLine("Sparar bok");
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