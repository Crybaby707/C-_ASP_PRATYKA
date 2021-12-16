using Microsoft.EntityFrameworkCore;
using System;
using TVShows.Domain;

namespace TVShows.Data
{
    public interface ITVShowsDbContext : IDisposable
    {
        DbSet<User> Users { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        int SaveChanges();
    }
}
