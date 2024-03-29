using Microsoft.EntityFrameworkCore;

namespace APIReact
{
    public class DbContextFactory
    {
        public DbContextFactory(string[] agrs)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var connectionString = configuration.GetConnectionString("EmployeeManger");
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
            optionsBuilder.UseSqlServer
        }
    }
}