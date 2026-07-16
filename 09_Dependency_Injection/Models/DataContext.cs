using Microsoft.EntityFrameworkCore;

namespace _09_Dependency_Injection.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLEXPRESS;Database=DependencyInjectionDb;Trusted_Connection=True; TrustServerCertificate=true");
        }
        public DbSet<Student> Students { get; set; }
    }
}
