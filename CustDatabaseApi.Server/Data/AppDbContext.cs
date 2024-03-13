using CustDatabaseApi.Server.Models; // Make sure this using directive is correct for your `Customer` model
using Microsoft.EntityFrameworkCore;

namespace CustDatabaseApi.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; } // Add this line if it's missing

        // Include DbSet properties for other entity models as needed
    }
}
