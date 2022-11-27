namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        // Skapa ett OrdetItem objekt
        // Initierar egenskaperna, dessa värden kommer förmodligen via ett inmatningsgränssnitt
        var orderItem = new OrderItem
        {
            Quantity = 2,
            DiscountCode = "AZ44589"
        };

        // Skapa ett book objekt...
        var book = new Book();
        book.ISBN = "978-1-4842-7868-0";
        book.Title = "Pro C# 10 with .NET 6";
        book.Author = "Andrew Troelsen, Phil Japikse";
        book.Pages = 1640;
        book.HasHardCover = false;

        // Placera produkt referensen till Product egenskapen på orderItem referensen...
        orderItem.Product = book;

        var bookInfo = (Book)orderItem.Product;

        // Låt oss se vad vi har skapat.
        Console.WriteLine(@"OrderItem: 
        Kvantitet: {0}
        Produktid: {1}
        ISBN: {2}
        Titel: {3}
        Författare: {4}
        Antal sidor: {5}
        Inbunden: {6}",
        orderItem.Quantity,
        orderItem.Product.ProductId,
        bookInfo.ISBN,
        bookInfo.Title,
        bookInfo.Author,
        bookInfo.Pages,
        bookInfo.HasHardCover
        );
        // Console.WriteLine(@"OrderItem: 
        // Kvantitet: {0}
        // Produktid: {1}
        // ISBN: {2}
        // Titel: {3}
        // Författare: {4}
        // Antal sidor: {5}
        // Inbunden: {6}",
        // orderItem.Quantity,
        // orderItem.Product.ProductId,
        // ((Book)orderItem.Product).ISBN,
        // ((Book)orderItem.Product).Title,
        // ((Book)orderItem.Product).Author,
        // ((Book)orderItem.Product).Pages,
        // ((Book)orderItem.Product).HasHardCover
        // );
    }
}
