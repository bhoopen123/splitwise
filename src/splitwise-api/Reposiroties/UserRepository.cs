using Splitwise.DbEntities;

namespace Splitwise.Reposiroties
{
    public class UserRepository : IUserRepository
    {
        private SplitwiseDbContext splitwiseDbContext;

        public UserRepository(SplitwiseDbContext splitwiseDbContext)
        {
            this.splitwiseDbContext = splitwiseDbContext;
        }

        public async Task<User?> GetUser(long id)
        {
            return await splitwiseDbContext.Users.FindAsync(id);
        }

        public async Task<User> CreateUser(User user)
        {
            var userEntry = await splitwiseDbContext.Users.AddAsync(user);
            await splitwiseDbContext.SaveChangesAsync();
            return userEntry.Entity;
        }
    }
}
