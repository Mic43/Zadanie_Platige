using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Platigue.Db
{
    public class PlatigueDbContextFactory : IDesignTimeDbContextFactory<PlatigueDbContext>
    {
        public static readonly string DefaultConnectionString = @"Server=(localdb)\mssqllocaldb;Database=Platigue;Trusted_Connection=True;";

        public PlatigueDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PlatigueDbContext>();

            optionsBuilder.UseSqlServer(DefaultConnectionString);

            return new PlatigueDbContext(optionsBuilder.Options);
        }
    }
}
