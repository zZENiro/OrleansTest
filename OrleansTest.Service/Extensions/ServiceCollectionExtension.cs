using Microsoft.Extensions.DependencyInjection;
using OrleansTest.Contract.Repositories;
using OrleansTest.Contract.Services;
using OrleansTest.Service.Data;
using OrleansTest.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrleansTest.Service.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddOrleansTestServices(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersListRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
