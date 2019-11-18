using criandoApi.Properties.Models;
using Microsoft.EntityFrameworkCore;

namespace criandoApi.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer()
        }
    }
}