﻿using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<User> DetailUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> ListUsers()
        {
            throw new NotImplementedException();
        }
    }
}
