using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platigue.Db;

using Microsoft.EntityFrameworkCore;

public sealed class PlatigueDbContext : DbContext
{
    // private readonly string _connectionString;

    /// <inheritdoc />
    public PlatigueDbContext(DbContextOptions<PlatigueDbContext> options)
        : base(options)
    {

    }

    public static PlatigueDbContext FromConnectionString (string connectionString)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PlatigueDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new PlatigueDbContext(optionsBuilder.Options);
    }

    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Invoice> Invoices => Set<Invoice>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>(b =>
        {
            b.Property(x => x.Currency)
                .HasMaxLength(3);
        });
    }
    public DbUpdateException? TrySaveChanges()
    {
        try
        {
            SaveChanges();
        }
        catch (DbUpdateException e)
        {
            return e;
        }

        return null;
    }
}