using Microsoft.Extensions.DependencyInjection;
using OrleansTest.Contract.Repositories;
using OrleansTest.Contract.Services;
using OrleansTest.Service.Data.Grains;
using OrleansTest.Service.Services.Grains;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrleansTest.Service.Extensions.Grains
{
    public static class GrainServiceCollectionExtension
    {
        public static void AddOrleansGrainTestServices(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersListRepositoryGrain>();
            services.AddScoped<IUserService, UserServiceGrain>();
        }
    }
}
