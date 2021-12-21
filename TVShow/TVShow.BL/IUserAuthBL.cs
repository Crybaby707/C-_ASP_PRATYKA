using TVShow.Domain;

namespace TVShow.BL
{
    public interface IUserAuthBL : IBaseBL
    {
        User GetUserById(int id);

        User GetByEmailAndPassword(string email, string password);
    }
}
