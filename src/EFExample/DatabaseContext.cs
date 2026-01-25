using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFExample;

public class DatabaseContext: DbContext
{
    public DbSet<Planet> Planets { get; set; }
    public DbSet<Moon> Moons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db").LogTo(Console.WriteLine, LogLevel.Information);
    }
}
