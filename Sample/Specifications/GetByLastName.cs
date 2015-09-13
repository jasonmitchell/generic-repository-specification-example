namespace Sample.Specifications
{
    using System;
    using System.Linq.Expressions;
    using Repositories.Models;
    using Repositories.Specifications;

    public class GetByLastName : ISpecification<Person>
    {
        private readonly string lastName;

        public GetByLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public Expression<Func<Person, bool>> IsSatisifiedBy()
        {
            return x => x.LastName == lastName;
        }
    }
}
