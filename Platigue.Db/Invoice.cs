using System.ComponentModel.DataAnnotations;

namespace Platigue.Db;

public class Invoice
{
    public Client? Client { get;  }
    public int ClientId { get;  set; }

    [Key]
    public string Number { get; private set; }
    public decimal Value { get;  set; }
    public string Currency { get;  set; }
    public decimal VAT { get;  set; }
    public DateTime IssueDate { get;  set; }
    public string Description { get;  set; }

    private Invoice()
    {
        
    }
    public Invoice(string number, Client client, decimal value, string currency, decimal vat, DateTime issueDate, string description)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value);
        ArgumentOutOfRangeException.ThrowIfNegative(vat);

        if (client == null) throw new ArgumentNullException(nameof(client));
        if (string.IsNullOrEmpty(currency))
            throw new ArgumentException("Value cannot be null or empty.", nameof(currency));
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException("Value cannot be null or empty.", nameof(description));
        if (string.IsNullOrEmpty(number)) throw new ArgumentException("Value cannot be null or empty.", nameof(number));

        Number = number;
        Value = value;
        Currency = currency;
        VAT = vat;
        IssueDate = issueDate;
        Description = description;
        ClientId = client.Id;
    }
}