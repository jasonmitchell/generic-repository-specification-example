namespace Sample.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public class QueryableRepository
    {
        private readonly DbContext context;

        public QueryableRepository(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> predicate = null) where T : class
        {
            var query = (IQueryable<T>)context.Set<T>();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query;
        }
    }
}
