using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TVShow.Data;
using TVShow.Domain;

namespace TVShow.DAL
{
    public class UserAuthRepository : BaseRepository, IUserAuthRepository
    {
        public UserAuthRepository(Func<ITVShowDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User Get(int id)
            => Query(context => context.Users.FirstOrDefault(p => p.Id == id));

        public User GetByEmailAndPassword(string email, string password)
            => Query(context =>
                context.Users.Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .FirstOrDefault(p => p.Email == email && p.Password == password));


        public Task<User> GetUserByEmailAsync(string userEmail)
            => Query(context => context.Users.FirstOrDefaultAsync(p => p.Email == userEmail));
    }
}
