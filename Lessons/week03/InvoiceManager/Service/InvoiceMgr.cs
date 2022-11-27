namespace InvoiceManager;

public class InvoiceMgr
{
    // private readonly string test = "nisse";
    public List<Invoice> Invoices { get; private set; } = new List<Invoice>();


    public void AddInvoice(Invoice invoice)
    {
        Invoices.Add(invoice);
    }

    public List<Invoice> ListAllInvoices()
    {
        return Invoices;
    }

    public bool Save()
    {
        return true;
    }
}