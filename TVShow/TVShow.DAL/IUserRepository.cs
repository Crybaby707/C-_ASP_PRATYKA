using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Domain;

namespace TVShows.DAL
{
    public interface IUserRepository : IBaseRepository
    {
        User GetById(int id);
    }
}
