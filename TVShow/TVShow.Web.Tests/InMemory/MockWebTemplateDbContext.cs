using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShow.Data;
using TVShow.Domain;

namespace TVShow.Web.Tests.InMemory
{
    public class MockTVShowDbContext : DbContext, ITVShowDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Domain.Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public MockTVShowDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
