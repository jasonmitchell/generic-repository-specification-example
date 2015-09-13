namespace Sample.Specifications
{
    using System;
    using System.Linq.Expressions;
    using Repositories.Models;
    using Repositories.Specifications;

    public class GetByFirstName : ISpecification<Person>
    {
        private readonly string firstName;

        public GetByFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public Expression<Func<Person, bool>> IsSatisifiedBy()
        {
            return x => x.FirstName == firstName;
        }
    }
}
