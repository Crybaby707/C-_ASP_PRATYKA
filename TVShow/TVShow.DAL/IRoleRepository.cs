using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Domain;

namespace TVShows.DAL
{
    public interface IRoleRepository : IBaseRepository
    {
        IList<Role> GetList();
    }
}
