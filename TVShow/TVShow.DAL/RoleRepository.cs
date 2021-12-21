using System;
using System.Collections.Generic;
using System.Linq;
using TVShow.Data;
using TVShow.Domain;

namespace TVShow.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(Func<ITVShowDbContext> getDbContext) : base(getDbContext)
        {

        }


        public IList<Role> GetList() => Query((context) => context.Roles.ToList());
    }
}
