using Splitwise.DbEntities;

namespace Splitwise.Reposiroties
{
    public interface IUserRepository : IDisposable
    {
        Task<User?> GetUser(long id);
        Task<User> CreateUser(User user);
    }
}
