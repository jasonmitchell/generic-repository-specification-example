namespace Sample.Repositories
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Specifications;

    public class SpecificationRepository
    {
        private readonly DbContext context;

        public SpecificationRepository(DbContext context)
        {
            this.context = context;
        }

        public ICollection<T> Find<T>(ISpecification<T> specification) where T : class
        {
            var query = context.Set<T>().Where(specification.IsSatisifiedBy());
            return query.ToList();
        }
    }
}