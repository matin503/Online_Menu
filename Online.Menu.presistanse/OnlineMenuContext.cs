using Microsoft.EntityFrameworkCore;
using Online.Menu.Core.Models;

namespace Online.Menu.presistance;

public class OnlineMenuContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<ItemModel> ItemModels { get; set; }
}
