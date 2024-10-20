namespace Platigue.Db;


public static class Queries
{
    public record GetClientsCountByCountryResult(string Country, int Count);

    public static IQueryable<GetClientsCountByCountryResult> GetClientsCountByCountry(this PlatigueDbContext context)
    {
        return context.Clients.GroupBy(x => x.Country,
            (country, clients) => new GetClientsCountByCountryResult(country, clients.Count()));
    }

    public record GetInvoicesValueByMonthResult(int Month, decimal TotalValue, decimal TotalValueWithTax);

    public static IQueryable<GetInvoicesValueByMonthResult> GetInvoicesValueByMonth(this PlatigueDbContext context)
    {
        return context.Invoices.GroupBy(x => x.IssueDate.Month,
            (month, invoices) =>
                new GetInvoicesValueByMonthResult(month,
                    invoices.Sum(x => x.Value),
                    invoices.Sum(x => x.Value + x.VAT)));
    }
    public record GetInvoicesByClientResult(int ClientId, int Count, decimal TotalValue, decimal TotalValueWithTax);

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