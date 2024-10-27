using Microsoft.EntityFrameworkCore;
using SolarTech.Models;

namespace SolarTech.Data
    {
    public class SolarTechDbContext(DbContextOptions<SolarTechDbContext> options) : DbContext(options)
        {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<Order>()
                .Property(o => o.NetAmount)
                .HasColumnType("decimal(18,2)");
            }
        }
    }