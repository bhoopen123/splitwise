using Splitwise.DbEntities;
using Splitwise.DTOs;

namespace Splitwise.Services
{
    public interface IUserService
    {
        Task<User?> GetUserById(long id);

        Task<User> RegisterUser(RegisterUserRequest user);
    }
}
