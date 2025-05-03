using IMS.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.Repo
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GeneralConfig> GeneralConfigs { get; set; }
        public DbSet<Category> CategoryConfigs { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ItemStock> ItemStocks { get; set; }
        public DbSet<Warehouse> Warehouses { get; set;}

    }
}
