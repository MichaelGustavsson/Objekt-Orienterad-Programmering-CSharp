namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        var product = new Product();
        var book = new Book
        {
            ItemNumber = "ART1234",
            ISBN = "123-3456-789",
            Title = "Pro C# 10 with .NET 6",
            Author = "Andrew Troelsen",
            Pages = 1600,
            Price = 450,
            IsInStock = true
        };

        var result = book.Save();

    }
}
