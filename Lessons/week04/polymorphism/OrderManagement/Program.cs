namespace OrderManagement;
class Program
{
    static void Main(string[] args)
    {
        var productList = new List<Product>{
            new Book("ABC123"){},
            new Shoe("CDE234"){},
            new Product("FGH678"){},
            new Product("IJK987"){},
            new Book("LMN444"){},
            new Book("OPQ666"){},
            new Shoe("RST888"){},
        };

        foreach (var item in productList)
        {
            item.Save();
        }
    }
}
