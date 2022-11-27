namespace OrderManagement;

public class Book : Product
{
    // Properties...
    public string ISBN { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; }
    public bool HasHardCover { get; set; } = false;

    public Book(string itemNumber) : base(itemNumber)
    {

    }
    // Methods...
    public override bool Save()
    {
        Console.WriteLine("Sparar bok");
        return true;
    }
    public override IProduct Find(string itemNumber)
    {
        throw new NotImplementedException();
    }
    public override List<IProduct> ListAllProducts()
    {
        throw new NotImplementedException();
    }
}