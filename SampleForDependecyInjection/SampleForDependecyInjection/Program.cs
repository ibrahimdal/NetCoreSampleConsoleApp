using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SampleForDependecyInjection.Services.Abstract;
using SampleForDependecyInjection.Services.Concrete;
using System;

namespace SampleForDependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(x =>
                {
                    x.ClearProviders();
                    x.AddConsole();
                })
                .AddSingleton<ISampleService, SampleService>()
                .BuildServiceProvider();

            var sampleService = serviceProvider.GetService<ISampleService>();

            sampleService.doWork(1);

            Console.ReadLine();

        }
    }
}
