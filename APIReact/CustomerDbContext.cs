using Microsoft.EntityFrameworkCore;
using APIReact.Entities;

namespace APIReact
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customer { get; set; }
    }
}