using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Services
{
    public interface IUserService
    {
        Task<User> DetailUser(string id);
        Task<IEnumerable<User>> ListUsers();
    }
}
