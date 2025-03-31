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

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    splitwiseDbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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
