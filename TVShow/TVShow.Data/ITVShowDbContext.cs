using Microsoft.EntityFrameworkCore;
using System;
using TVShow.Domain;

namespace TVShow.Data
{
    public interface ITVShowDbContext : IDisposable
    {
        DbSet<User> Users { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        int SaveChanges();
    }
}
