namespace Sample.Repositories.Migrations
{
    using System.Configuration;
    using System.Data.Entity.Infrastructure;
    using Models;

    public class MigrationsContextFactory : IDbContextFactory<SampleContext>
    {
        public SampleContext Create()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
            return new SampleContext(connectionString);
        }
    }
}