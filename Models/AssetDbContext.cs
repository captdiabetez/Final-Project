using Microsoft.EntityFrameworkCore;

namespace AssetASP.Models
{
    public class AssetDbContext: DbContext
    {
        public AssetDbContext (DbContextOptions<AssetDbContext> options)
            : base(options)
            {
            }
            public DbSet<Asset> Assets {get; set;}
            public DbSet<User> Users {get; set;}
    }
}