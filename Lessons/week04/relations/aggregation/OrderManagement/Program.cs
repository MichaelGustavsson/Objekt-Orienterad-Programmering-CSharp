namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        // Skapa ett nytt order objekt...
        var order = new Order();

        // Skapa ett OrderItem objekt
        // Initierar egenskaperna, dessa värden kommer förmodligen via ett inmatningsgränssnitt
        var orderItem = new OrderItem
        {
            Quantity = 2,
            DiscountCode = "AZ443777",
            Product = new Book
            {
                ISBN = "978-1-4842-7868-0",
                Title = "Pro C# 10 with .NET 6",
                Author = "Andrew Troelsen, Phil Japikse",
                Pages = 1640,
                HasHardCover = false,
            }
        };

        order.Items.Add(orderItem);

        orderItem = new OrderItem
        {
            Quantity = 1,
            DiscountCode = "AZ44589",
            Product = new Book
            {
                ISBN = "978-0-13-235088-4",
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Pages = 431,
                HasHardCover = false
            }
        };

        order.Items.Add(orderItem);

        Console.WriteLine(@"Beställningsinformation
        id: {0}
        beställningsdatum: {1}
        Antal orderrader: {2}",
        order.OrderId,
        order.OrderDate,
        order.Items.Count);

        Console.WriteLine(@"Order rader");

        foreach (var item in order.Items)
        {
            Console.WriteLine(@"
            Kvantitet: {0}
            Rabattkod: {1}",
            item.Quantity,
            item.DiscountCode);

            Console.WriteLine("------------------------------------------------------------");

            var bookInfo = (Book)item.Product!;

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
        }








        // var bookInfo = (Book)orderItem.Product;

        // Låt oss se vad vi har skapat.
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
        // bookInfo.ISBN,
        // bookInfo.Title,
        // bookInfo.Author,
        // bookInfo.Pages,
        // bookInfo.HasHardCover
        // );
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
