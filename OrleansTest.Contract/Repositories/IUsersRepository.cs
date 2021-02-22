using Orleans;
using OrleansTest.Contract.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrleansTest.Contract.Repositories
{
    public interface IUsersRepository : IGrainWithGuidKey
    {
        Task<IEnumerable<User>> GetUsers(string name);

        Task UpdateUser(User oldOne, User newOne);

        Task DeleteUser(User user);

        Task<User> CreateUser(User user);
    }
}
