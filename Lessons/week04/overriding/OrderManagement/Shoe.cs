namespace OrderManagement;

public class Shoe : Product
{
    // Properties...
    public string Brand { get; set; }
    public double Size { get; set; }

    // Constructors...
    public Shoe(string itemNumber) : base(itemNumber)
    {
        Brand = "";
    }

    // Methods...
    public override bool Save()
    {
        Console.WriteLine("Sparar sko");
        return true;
    }

    public override string ToString()
    {
        return $"Artikelnummer: {ItemNumber} - Märke: {Brand}";
    }
}