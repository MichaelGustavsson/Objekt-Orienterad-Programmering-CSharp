namespace OrderManagement;

public class Shoe : Product, IClothing
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

    public override IProduct Find(string itemNumber)
    {
        throw new NotImplementedException();
    }

    public override List<IProduct> ListAllProducts()
    {
        throw new NotImplementedException();
    }
}