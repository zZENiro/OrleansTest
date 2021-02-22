using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orleans;
using Orleans.Hosting;
using OrleansTest.Service.Extensions.Grains;
using Orleans.Configuration;

namespace OrleansTest.FrontApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseOrleans(siloConfig => 
                {
                    siloConfig.UseLocalhostClustering()
                        .ConfigureServices(GrainServiceCollectionExtension.AddOrleansGrainTestServices)
                        .Configure<HostOptions>(options =>
                        {
                            options.ShutdownTimeout = TimeSpan.FromSeconds(10);
                        })
                        .Configure<ClusterOptions>(options =>
                        {
                            options.ClusterId = "dev";
                            options.ServiceId = "OrleansTest.FrontApi";
                        });
                });
    }
}
