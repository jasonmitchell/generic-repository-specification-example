namespace Sample.Repositories.Migrations
{
    using System.Data.Entity.Migrations;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SampleContext context)
        {
            context.People.AddOrUpdate(
                x => x.Id,
                new Person { Id = 1, FirstName = "Jason", LastName = "Mitchell" },
                new Person { Id = 2, FirstName = "Adifferent", LastName = "Mitchell" },
                new Person { Id = 3, FirstName = "Jason", LastName = "Notmitchell" },
                new Person { Id = 4, FirstName = "Adifferent", LastName = "Notmitchell" }
            );
        }
    }
}
