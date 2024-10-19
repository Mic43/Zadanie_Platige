using Microsoft.Data.SqlClient;
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

            var context = CreateContext();
            if (context == null)
            {
                MessageBox.Show("Connection error");
                return;
            }

            Application.Run(new MainForm(context));
        }

        private static string GetConnectionStringFromUser()
        {
            string username = "dsds";
            string password = "";

            string dataSource = "dsds";
            string dataBaseName = "dsdsds";

            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = dataBaseName,
                UserID = username,
                Password = password,
                IntegratedSecurity = false
            };
            return builder.ConnectionString;
        }
        private static PlatigueDbContext? CreateContext(bool useDefault = true)
        {
            void TrySeedData(PlatigueDbContext ctx)
            {
                if (!ctx.Clients.Any() && !ctx.Invoices.Any())
                {
                    var client = new Client("dsds", "dsdsds", "dsdsds", "dsdsds", "dsdsds", true);
                    client.AddInvoice(new Invoice("2121", client,20,"PLN",10,DateTime.Now,"kwa"));
                    
                    ctx.Clients.AddRange(
                        client,
                        new Client("dsds2", "dsdsds", "dsdsds", "dsdsds", "dsdsds", false),
                        new Client("dsds3", "dsdsds", "dsdsds", "dsdsds", "dsdsds", false));
                }


                ctx.SaveChanges();
            }

            Func<string> getConnString =
                useDefault ? () => PlatigueDbContextFactory.DefaultConnectionString : GetConnectionStringFromUser;


            var ctx = PlatigueDbContext.FromConnectionString(getConnString());

            if (!ctx.Database.CanConnect())
                return null;

            TrySeedData(ctx);
            return ctx;
        }
    }
}