using Microsoft.EntityFrameworkCore;
using APIReact.Entities;

namespace APIReact
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeEntity> Employee { get; set; }
    }
}