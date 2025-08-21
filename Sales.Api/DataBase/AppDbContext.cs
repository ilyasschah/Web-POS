using Microsoft.EntityFrameworkCore;
using Sales.Api.Domain;
namespace Sales.Api.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
