namespace InvoiceManager;

public class User
{
    private string _password = "";
    public string UserName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password
    {
        set
        {
            _password = value;
        }
    }
}