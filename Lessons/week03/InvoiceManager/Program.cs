namespace InvoiceManager;

class Program
{
    static void Main(string[] args)
    {
        var mgr = new InvoiceMgr();

        var invoice = new Invoice("abc123");

        var invoiceItem = new InvoiceItem()
        {
            ProductName = "Snus"
        };

    }
}
