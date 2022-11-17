namespace OrderManagement;

public class Customer
{
    public Guid CustomerId { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string Phone { get; set; } = "";
    public string Address { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";

    public Customer Find(string email)
    {
        // Logik för att hämta en kund ifrån en databas via dess e-post adress...
        return new Customer();
    }
    public List<Customer> ListAll()
    {
        // Logik för att hämta alla kunder ur databasen...
        return new List<Customer>();
    }
    public bool Save()
    {
        // Verifiera att tillståndet är korrekt innan vi sparar...
        if (!Validate())
        {
            throw new Exception("Går inte att spara på grund det saknas information");
        }
        // Logik för att spara en ny kund
        return true;
    }
    private bool Validate()
    {
        var isValid = true;

        if (string.IsNullOrWhiteSpace(Name)) isValid = false;
        if (string.IsNullOrWhiteSpace(Email)) isValid = false;

        return isValid;
    }
}