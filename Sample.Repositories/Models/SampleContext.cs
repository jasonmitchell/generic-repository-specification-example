using System.Data.Entity;
using System.Reflection;

namespace Sample.Repositories.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
