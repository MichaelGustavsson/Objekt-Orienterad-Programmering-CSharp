namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer();

        Console.WriteLine("CustomerId: {0}", customer.CustomerId);
        var isOk = customer.Save();

    }
}
