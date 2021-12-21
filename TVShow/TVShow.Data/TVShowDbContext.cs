using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using TVShow.Domain;

namespace TVShow.Data
{
    public class TVShowDbContext : DbContext, ITVShowDbContext
    {
        public static readonly ILoggerFactory DbContextLoggerFactory;

        //static TVShowDbContext()
        //{
        //    //DbContextLoggerFactory = new LoggerFactory();
        //    //DbContextLoggerFactory.AddConsole();
        //    //DbContextLoggerFactory.AddNLog();
        //}

        public TVShowDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=(local);Initial Catalog=TVShow;Trusted_Connection=True;MultipleActiveResultSets=true");
            //options.UseLoggerFactory(DbContextLoggerFactory);
            //options.EnableSensitiveDataLogging(true);
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var seeder = new Seeder();
            seeder.Seed(modelBuilder);
        }
    }

}
