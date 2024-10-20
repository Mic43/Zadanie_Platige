namespace Platigue.Db;


public static class Queries
{
    public static IQueryable<GetClientsCountByCountryResult> GetClientsCountByCountry(this PlatigueDbContext context)
    {
        return context.Clients.GroupBy(x => x.Country,
            (country, clients) => new GetClientsCountByCountryResult(country, clients.Count()));
    }

    public static IQueryable<GetInvoicesValueByMonthResult> GetInvoicesValueByMonth(this PlatigueDbContext context)
    {
        return context.Invoices.GroupBy(x => x.IssueDate.Month,
            (month, invoices) =>
                new GetInvoicesValueByMonthResult(month,
                    invoices.Sum(x => x.Value),
                    invoices.Sum(x => x.Value + x.VAT)));
    }
    public static IQueryable<GetInvoicesByClientResult> GetInvoicesByClient(this PlatigueDbContext context)
    {
        return context.Invoices.GroupBy(x => x.ClientId,
            (clientId, invoices)
                => new GetInvoicesByClientResult(clientId, 
                    invoices.Count(),
                    invoices.Sum(x => x.Value),
                    invoices.Sum(x => x.Value + x.VAT)));
    }
}

public class GetClientsCountByCountryResult(string country, int count)
{
    public string Country { get; } = country;
    public int Count { get; } = count;
}

public class GetInvoicesValueByMonthResult(int month, decimal totalValue, decimal totalValueWithTax)
{
    public int Month { get; } = month;
    public decimal TotalValue { get; } = totalValue;
    public decimal TotalValueWithTax { get; } = totalValueWithTax;
}
public class GetInvoicesByClientResult(int clientId, int count, decimal totalValue, decimal totalValueWithTax)
{
    public int ClientId { get; } = clientId;
    public int Count { get; } = count;
    public decimal TotalValue { get; } = totalValue;
    public decimal TotalValueWithTax { get; } = totalValueWithTax;
}