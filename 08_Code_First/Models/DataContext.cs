using Microsoft.EntityFrameworkCore;

namespace _08_Code_First.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLEXPRESS; Database=ProductDB; Trusted_Connection=true; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasOne(b => b.Category)
                .WithOne(c => c.Brand)
                .HasForeignKey<Category>(c => c.BrandId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
