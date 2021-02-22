using OrleansTest.Contract.Contracts;
using OrleansTest.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansTest.Service.Data
{
    public class UsersListRepository : IUsersRepository
    {
        private readonly ICollection<User> _users;

        public UsersListRepository()
        {
            _users = new List<User> { };

            Enumerable.Range(0, 100).ToList<int>().ForEach(i => _users.Append(new User() { Name = $"Nikita_{i}", Surname = $"Vedernikov_{i}", Birthdate = DateTime.Now.AddDays(-i) }));
        }

        public async Task<User> CreateUser(User user) => _users.Append(user).Last();

        public async Task DeleteUser(User user) => _users.Remove(user);

        public async Task<IEnumerable<User>> GetUsers(string name) => _users.Where(u => u.Name == name).ToList();

        public async Task UpdateUser(User oldOne, User newOne)
        {
            var updatee = _users.Where(u => u.Equals(oldOne)).FirstOrDefault();
            updatee.Name = newOne?.Name;
            updatee.Surname = newOne?.Surname;
            updatee.Birthdate = newOne.Birthdate;
        }
    }
}
