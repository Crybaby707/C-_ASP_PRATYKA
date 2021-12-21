using System;
using System.Collections.Generic;
using TVShow.Domain;

namespace TVShow.DAL
{
    public interface IRoleRepository : IBaseRepository
    {
        IList<Role> GetList();
    }
}
