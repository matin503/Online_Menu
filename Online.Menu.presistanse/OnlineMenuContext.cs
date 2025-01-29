using Microsoft.EntityFrameworkCore;
using Online.Menu.Core.Models;

namespace Online.Menu.presistance;

internal partial class OnlineMenuContext(DbContextOptions<OnlineMenuContext> options) : DbContext(options)
{
    public virtual DbSet<ItemModel> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemModel>(entity =>
        {
            entity.ToTable("Item");
        });
    }
}
