using Microsoft.EntityFrameworkCore;
using try_razor.Models;

namespace try_razor.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}