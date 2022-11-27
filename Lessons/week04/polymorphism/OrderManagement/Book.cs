namespace OrderManagement;

public class Book : Product
{
    // Properties...
    public string ISBN { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; }
    public bool HasHardCover { get; set; } = false;

    // Constructors...
    public Book(string itemNumber) : base(itemNumber)
    {
    }

    // Methods...
    public override bool Save()
    {
        Console.WriteLine("Sparar bok");
        return true;
    }
}