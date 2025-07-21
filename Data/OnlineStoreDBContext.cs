using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineStoreDouble.Models;

namespace OnlineStoreDouble.Data
{
    public class OnlineStoreDBContext : DbContext
    {
    public OnlineStoreDBContext(DbContextOptions<OnlineStoreDBContext> options) : base(options) { }
        public DbSet<Product> Products { get;set; }
        public DbSet<ProductCategory> ProductCategories { get;set; }
    }
}
