using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShow.Domain;

namespace TVShow.Web.Tests.InMemory
{
    public class RoleSeed : Seed<Role>
    {
        public override List<Role> Init()
        {
            return new List<Role>()
            {
                new Role() {Id = 1, Code = "admin", Name = "Administrator"},
                new Role() {Id = 2, Code = "user", Name = "Regular User"}
            };
        }
    }
}
