using OrleansTest.Contract.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace OrleansTest.Contract.Services
{
    public interface IUserService : IGrainWithGuidKey
    {
        Task DoSomething();
    }
}
