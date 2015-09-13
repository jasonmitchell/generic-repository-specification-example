namespace Sample
{
    using System;
    using System.Configuration;
    using Repositories;
    using Repositories.Models;
    using Repositories.Specifications;
    using Specifications;

    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
            using (var context = new SampleContext(connectionString))
            {
                // IQUERYABLE REPOSITORY
                //var repository = new QueryableRepository(context);
                //var people = repository.Query<Person>(x => x.FirstName == "Jason").ToList();

                // OR
                //var people = repository.Query<Person>().Where(x => x.FirstName == "Jason").ToList();

                // WHY NOT JUST USE THE CONTEXT??
                //var people = context.People.Where(x => x.FirstName == "Jason").ToList();

                var repository = new SpecificationRepository(context);
                var specification = new GetByFirstName("Jason").And(new GetByLastName("Mitchell"));

                var people = repository.Find(specification);
                Console.WriteLine("Found {0} people", people.Count);
                Console.ReadLine();
            }
        }
    }
}
