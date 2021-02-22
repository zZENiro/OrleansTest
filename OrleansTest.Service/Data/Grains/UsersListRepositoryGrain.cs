using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using OrleansTest.Contract.Contracts;
using OrleansTest.Contract.Repositories;
using System.Linq;

namespace OrleansTest.Service.Data.Grains
{
    public class UsersListRepositoryGrain : Grain, IUsersRepository
    {
        private readonly ICollection<User> _users;

        public UsersListRepositoryGrain()
        {
            _users = new List<User> { };
        }

        public async Task<User> CreateUser(User user)
        {
            return _users.Append(user).Last();
        }

        public async Task DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetUsers(string name)
        {
            return _users.Where(u => u.Name == name).ToList();
        }

        public async Task UpdateUser(User oldOne, User newOne)
        {
            var updateeUser = _users.Where(u => u.Equals(oldOne)).FirstOrDefault();
            updateeUser.Name = newOne?.Name;
            updateeUser.Surname = newOne?.Surname;
            updateeUser.Birthdate = newOne.Birthdate;
        }
    }
}
