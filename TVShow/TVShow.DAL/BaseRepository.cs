using System;
using TVShows.Data;

namespace TVShows.DAL
{
    public class BaseRepository
    {

        private readonly Lazy<ITVShowsDbContext> lazyContext;

        private ITVShowsDbContext context => lazyContext.Value;


        protected readonly Func<ITVShowsDbContext> getDbContext;

        public BaseRepository(Func<ITVShowsDbContext> getDbContext)
        {
            this.getDbContext = getDbContext;
            lazyContext = new Lazy<ITVShowsDbContext>(() => getDbContext());
        }

        protected T Execute<T>(Func<ITVShowsDbContext, T> functor)
        {
            using (var dbContext = getDbContext())
            {
                return functor(dbContext);
            }
        }

        protected T Query<T>(Func<ITVShowsDbContext, T> functor)
        {
            return functor(context);
        }
    }
}
