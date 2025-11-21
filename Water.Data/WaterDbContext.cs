using Microsoft.EntityFrameworkCore;

namespace Water.Data;

public class WaterDbContext : DbContext
{
    public WaterDbContext(DbContextOptions<WaterDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure entity models here
    }
}
