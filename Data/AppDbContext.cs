using FixIt.Models;
using Microsoft.EntityFrameworkCore;

namespace FixIt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customer - RepairRequest 
            modelBuilder.Entity<RepairRequest>()
                .HasOne(r => r.Customer)
                .WithMany()
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Technician - RepairRequest 
            modelBuilder.Entity<RepairRequest>()
                .HasOne(r => r.Technician)
                .WithMany()
                .HasForeignKey(r => r.TechnicianId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
