using Splitwise.DbEntities;

namespace Splitwise.Reposiroties
{
    public interface IUserRepository
    {
        Task<User?> GetUser(long id);
        Task<User> CreateUser(User user);
    }
}
