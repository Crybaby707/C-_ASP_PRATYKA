using System;
using System.Collections.Generic;
using System.Linq;
using TVShows.Data;
using TVShows.Domain;

namespace TVShows.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(Func<ITVShowsDbContext> getDbContext) : base(getDbContext)
        {

        }


        public IList<Role> GetList() => Query((context) => context.Roles.ToList());
    }
}
