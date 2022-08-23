using CodeFirst.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class TestDbContextcs : DbContext
    {
        public TestDbContextcs() { }
        public TestDbContextcs(DbContextOptions<TestDbContextcs> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Test"));
            }
        }

        public DbSet<User> Users {get; set;}
        public DbSet<Role> Roles { get; set; }
        public DbSet<Auth> Authes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }

}
