namespace Sample.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public class NonQueryableRepository
    {
        private readonly DbContext context;

        public NonQueryableRepository(DbContext context)
        {
            this.context = context;
        }

        public ICollection<T> Query<T>(Expression<Func<T, bool>> predicate = null) where T : class
        {
            var query = (IQueryable<T>)context.Set<T>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ToList();
        }
    }
}
