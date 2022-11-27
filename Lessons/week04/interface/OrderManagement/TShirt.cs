namespace OrderManagement;

public class TShirt : Product, IClothing
{
    public string Brand { get; set; }
    public double Size { get; set; }

    public TShirt(string brand, string itemNumber) : base(itemNumber)
    {
        Brand = brand;
    }
}