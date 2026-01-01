using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Entity_Framework.Models;
using System.IO;

namespace Entity_Framework.DAL
{
    public class IETDbContext : DbContext
    {
        public DbSet<Emp> emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                IConfiguration config = builder.Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("IETDb"));
            }
        }
    }
}
