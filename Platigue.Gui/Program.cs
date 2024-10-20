using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Platigue.Db;

namespace Platigue.Gui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string? conn = GetConnectionString(false);
            if (conn == null)
            {
                Application.Exit();
                return;
            }

            Application.Run(new MainForm(new DbContextFactory(conn)));
        }

        private static string? GetConnectionStringFromUser()
        {
            using DatabaseConnectionDialog dialog = new DatabaseConnectionDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return dialog.CanConnect ? dialog.ConnectionString : null;
        }
        private static string? GetConnectionString(bool useDefault = true)
        {
            void PrepareDb(string conn)
            {
                void TrySeedData(PlatigueDbContext ctx)
                {
                    if (!ctx.Clients.Any() && !ctx.Invoices.Any())
                    {
                        // Client 1
                        var client1 = new Client("John Doe", "JD", "USA", "123 Main St, New York, NY", "1234567890", true);
                        client1.AddInvoice(new Invoice("INV001", client1, 150.00m, "USD", 0.00m, DateTime.Now.AddDays(-10), "Consulting Services"));

                        // Client 2
                        var client2 = new Client("Jane Smith", "JS", "Canada", "456 Elm St, Toronto, ON", "9876543210", false);
                        client2.AddInvoice(new Invoice("INV002", client2, 250.00m, "CAD", 25.00m, DateTime.Now.AddDays(-5), "Web Development"));
                        client2.AddInvoice(new Invoice("INV003", client2, 100.00m, "CAD", 10.00m, DateTime.Now.AddDays(-2), "Design Services"));

                        // Client 3
                        var client3 = new Client("Alice Johnson", "AJ", "UK", "789 Oak St, London", "5555555555", true);
                        client3.AddInvoice(new Invoice("INV004", client3, 300.00m, "GBP", 30.00m, DateTime.Now.AddDays(-15), "Marketing Strategy"));

                        // Client 4
                        var client4 = new Client("Bob Brown", "BB", "Germany", "321 Pine St, Berlin", "1112223333", false);
                        client4.AddInvoice(new Invoice("INV005", client4, 450.00m, "EUR", 45.00m, DateTime.Now.AddDays(-1), "SEO Services"));
                        client4.AddInvoice(new Invoice("INV006", client4, 200.00m, "EUR", 20.00m, DateTime.Now.AddDays(-3), "Content Writing"));

                        // Client 5
                        var client5 = new Client("Charlie Green", "CG", "Australia", "654 Maple St, Sydney", "4443332222", true);
                        client5.AddInvoice(new Invoice("INV007", client5, 500.00m, "AUD", 50.00m, DateTime.Now.AddDays(-20), "App Development"));

                        // Additional clients with different countries
                        var client6 = new Client("Diana Prince", "DP", "Brazil", "987 Cedar St, São Paulo", "8887776666", true);
                        var client7 = new Client("Ethan Hunt", "EH", "Japan", "159 Birch St, Tokyo", "9998887777", false);

                        ctx.Clients.AddRange(
                            client1, client2, client3, client4, client5, client6, client7);
                    }

                    ctx.SaveChanges();
                }

                using (var platigueDbContext = PlatigueDbContext.FromConnectionString(conn))
                {
                    platigueDbContext.Database.Migrate();
                    TrySeedData(platigueDbContext);
                }
            }

            Func<string?> getConnString =
                useDefault ? () => PlatigueDbContextFactory.DefaultConnectionString :
                    GetConnectionStringFromUser;

            var conn = getConnString();
            if (conn == null)
                return null;

            PrepareDb(conn);
            return conn;
        }
    }
}