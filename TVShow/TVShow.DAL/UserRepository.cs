using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShow.Data;
using TVShow.Domain;

namespace TVShow.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(Func<ITVShowDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User GetById(int id)
            => Query(context => context.Users.FirstOrDefault(p => p.Id == id));
    }
}
