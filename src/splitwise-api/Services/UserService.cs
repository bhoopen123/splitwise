using Splitwise.DbEntities;
using Splitwise.DTOs;
using Splitwise.Reposiroties;

namespace Splitwise.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task<User?> GetUserById(long id)
        {
            return await userRepository.GetUser(id);
        }

        public async Task<User> RegisterUser(RegisterUserRequest user)
        {
            var entity = new User
            {
                Name = user.Name,
                Phone = user.Phone,
                Password = user.Password
            };

            return await userRepository.CreateUser(entity);
        }
    }
}
