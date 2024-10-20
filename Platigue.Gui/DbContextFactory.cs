using Platigue.Db;

namespace Platigue.Gui;

public class DbContextFactory(string connectionString)
{
    private readonly string _connectionString = connectionString;

    public PlatigueDbContext Create()
    {
        return PlatigueDbContext.FromConnectionString(_connectionString);
    }
}