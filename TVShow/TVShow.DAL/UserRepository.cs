using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Data;
using TVShows.Domain;

namespace TVShows.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(Func<ITVShowsDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User GetById(int id)
            => Query(context => context.Users.FirstOrDefault(p => p.Id == id));
    }
}
