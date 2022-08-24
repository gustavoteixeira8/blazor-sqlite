using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=Database\test.db");

        public DbSet<User> Users { get; set; }
    }
}
