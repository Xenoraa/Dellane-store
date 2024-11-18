using Microsoft.EntityFrameworkCore;

namespace Dellane_store.API.Models
{
    public class StoreContext : DbContext

    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public StoreContext(DbContextOptions<StoreContext>options) : base(options) {
        }
    }
}
