using Microsoft.EntityFrameworkCore;
using sites_api.Sites.Models;

namespace sites_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Site> Sites { get; set; }
    }
}
