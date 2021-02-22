using OrleansTest.Contract.Services;
using OrleansTest.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansTest.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task DoSomething()
        {
            var users = await _usersRepository.GetUsers("Nikita");

            users.Append(new Contract.Contracts.User()
            {
                Birthdate = DateTime.Now,
                Name = "Nikita",
                Surname = "Vedernikov"
            });
        }
    }
}
