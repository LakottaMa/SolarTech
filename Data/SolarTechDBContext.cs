using Microsoft.EntityFrameworkCore;
using SoloarTech.Models;

namespace SolarTech.Data
    {
    public class SolarTechDBContext(DbContextOptions<SolarTechDBContext> options) : DbContext(options)
        {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between the Customer and Order entities
            // A customer can have many orders
            // An order belongs to one customer
            // The foreign key is CustomerId
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
            }
        }
    }
