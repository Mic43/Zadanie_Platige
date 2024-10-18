using Microsoft.EntityFrameworkCore;

namespace Platigue.Db;

public class Client
{
    public int Id { get;  private set; }
    public string Name { get;  set; }
    public string Shortcut { get;  set; }
    public string Country { get;  set; }
    public string Address { get;  set; }
    public string NIP { get;  set; }
    public bool IsActive { get;  set; }

    private readonly List<Invoice> _invoices = [];
    public ICollection<Invoice> Invoices => _invoices;

    private Client()
    {
        
    }
    public Client(int id, string name, string shortcut, string country, string address, string nip, bool isActive)
    {
        if (string.IsNullOrEmpty(nip)) throw new ArgumentException("Value cannot be null or empty.", nameof(nip));
        
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Shortcut = shortcut ?? throw new ArgumentNullException(nameof(shortcut));
        Country = country ?? throw new ArgumentNullException(nameof(country));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        NIP = nip ?? throw new ArgumentNullException(nameof(nip));
        IsActive = isActive;
    }

    public void AddInvoice(Invoice invoice)
    {
        if (invoice == null) throw new ArgumentNullException(nameof(invoice));
        _invoices.Add(invoice);
    }
}