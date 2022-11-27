namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        var book = new Book("ZZ23456");
        book.Save();

        var shoe = new Shoe("FGT567");
        shoe.Brand = "Adidas";
        shoe.Save();

        Console.WriteLine(book.ToString());
        Console.WriteLine(shoe.ToString());

    }
}
