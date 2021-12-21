using System.Threading.Tasks;
using TVShow.Domain;

namespace TVShow.DAL
{
    public interface IUserAuthRepository : IBaseRepository
    {
        User Get(int id);

        Task<User> GetUserByEmailAsync(string userEmail);

        User GetByEmailAndPassword(string email, string password);

    }
}
