using Microsoft.EntityFrameworkCore;
using TVShow.Domain;

namespace TVShow.Data
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
    }
}

