using Microsoft.EntityFrameworkCore;
using ShopingApp.Models;

namespace ShopingApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<reg> Register { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> obj) : base(obj)
        {

        }
    }
}
