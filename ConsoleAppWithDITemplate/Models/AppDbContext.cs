using ConsoleAppWithDITemplate.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppWithDITemplate.Models;

public class AppDbContext : DbContext
{
    public DbSet<MyDbEntity> MyDbEntities { get; set; } = null!;

    // Add your DbSets here

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // Add your custom logic here
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Add your custom model configurations here
    }

}
