namespace OrderManagement;

public class Book : Product
{
    public string ISBN { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; }
    public bool HasHardCover { get; set; } = false;
}