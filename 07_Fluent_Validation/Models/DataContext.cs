using Microsoft.EntityFrameworkCore;

namespace _07_Fluent_Validation.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLEXPRESS; Database=ProductDB; Trusted_Connection=true; TrustServerCertificate=true");
        }
    }
}
