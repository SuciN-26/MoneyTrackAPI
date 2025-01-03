using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
