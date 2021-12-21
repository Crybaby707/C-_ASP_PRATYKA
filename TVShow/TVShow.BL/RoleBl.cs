using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShow.DAL;
using TVShow.Domain;

namespace TVShow.BL
{
    public class RoleBL : IRoleBL
    {
        private readonly IRoleRepository roleRepository;

        public RoleBL(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public IList<Role> GetList()
        {
            return roleRepository.GetList();
        }
    }
}
