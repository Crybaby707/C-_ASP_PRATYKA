using System;
using TVShow.Data;

namespace TVShow.DAL
{
    public class BaseRepository
    {

        private readonly Lazy<ITVShowDbContext> lazyContext;

        private ITVShowDbContext context => lazyContext.Value;


        protected readonly Func<ITVShowDbContext> getDbContext;

        public BaseRepository(Func<ITVShowDbContext> getDbContext)
        {
            this.getDbContext = getDbContext;
            lazyContext = new Lazy<ITVShowDbContext>(() => getDbContext());
        }

        protected T Execute<T>(Func<ITVShowDbContext, T> functor)
        {
            using (var dbContext = getDbContext())
            {
                return functor(dbContext);
            }
        }

        protected T Query<T>(Func<ITVShowDbContext, T> functor)
        {
            return functor(context);
        }
    }
}
