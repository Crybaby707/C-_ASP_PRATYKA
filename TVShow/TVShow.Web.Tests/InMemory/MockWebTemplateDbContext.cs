using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Data;
using TVShows.Domain;

namespace TVShows.Web.Tests.InMemory
{
    public class MockTVShowsDbContext : DbContext, ITVShowsDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Domain.Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public MockTVShowsDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
