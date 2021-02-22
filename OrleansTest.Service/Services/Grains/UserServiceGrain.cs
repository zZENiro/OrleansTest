using OrleansTest.Contract.Repositories;
using OrleansTest.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrleansTest.Service.Services.Grains
{
    public class UserServiceGrain : Orleans.Grain, IUserService
    {
        private readonly IUsersRepository _usersRepository;

        public UserServiceGrain(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task DoSomething()
        {
            var result = await _usersRepository.GetUsers("Nikita");
        }
    }
}
