namespace SimpleIndexers;
class SimpleList
{
    private string[] vehicles = new string[5];

    public int Length
    {
        get { return vehicles.Length; }
    }
    // Indexer...
    public string this[int index]
    {
        get { return vehicles[index]; }
        set { vehicles[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var soldVehicles = new SimpleList();
        soldVehicles[0] = "Ford";
        soldVehicles[1] = "Fiat";
        soldVehicles[2] = "Kia";
        soldVehicles[3] = "Audi";
        soldVehicles[4] = "Nissan";

        Console.WriteLine("Såld bil: {0}", soldVehicles[3]);

        for (var i = 0; i < soldVehicles.Length; i++)
        {
            Console.WriteLine("Bil tillverkare: {0}", soldVehicles[i]);
        }
    }
}
