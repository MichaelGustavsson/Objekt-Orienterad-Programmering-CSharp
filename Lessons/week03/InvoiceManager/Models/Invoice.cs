namespace InvoiceManager;

public class Invoice
{
    private string _invoiceNumber;
    private Guid _invoiceId;
    public Guid InvoiceId { get; set; } = Guid.NewGuid();

    public Guid GetInvoiceId()
    {
        return _invoiceId;
    }

    public void SetInvoiceId(Guid id)
    {
        _invoiceId = id;
    }
    public string InvoiceNumber { get; private set; } = "";

    public Invoice(string invoiceNumber)
    {
        _invoiceNumber = invoiceNumber;
    }

    public void AddInvoice(Invoice invoice)
    {

    }
}