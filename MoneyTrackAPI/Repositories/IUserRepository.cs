using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(string id);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
