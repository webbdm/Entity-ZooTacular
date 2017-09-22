using System.Data.Entity;
using WebApplication2.Data_Models;

namespace WebApplication2.DataModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ZooTacular")
        { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Zookeeper> Zookeepers { get; set; }
    }
}