using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.ApplicationContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .;database=mvc;trusted_connection = true ; TrustServerCertificate=true");
        }
    }
}
