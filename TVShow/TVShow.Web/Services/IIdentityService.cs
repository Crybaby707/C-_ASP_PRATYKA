namespace TVShow.Web.Services
{
    public interface IIdentityService
    {
        string Authenticate(string email, string password);
    }
}
