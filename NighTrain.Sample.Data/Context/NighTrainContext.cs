using Microsoft.EntityFrameworkCore;
using NighTrain.Sample.Data.Configuration;
using NighTrain.Sample.Domain.Entities;

namespace NighTrain.Sample.Data.Context
{
    public class NighTrainContext : DbContext
    {
        public NighTrainContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NighTrainTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
