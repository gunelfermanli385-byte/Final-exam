using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.Data
{
    public class DewiDbContext : DbContext
    {
        public DewiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>products { get; set;  }

    }
}
