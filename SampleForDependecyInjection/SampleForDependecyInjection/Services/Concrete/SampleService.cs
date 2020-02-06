using Microsoft.Extensions.Logging;
using SampleForDependecyInjection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDependecyInjection.Services.Concrete
{
    public class SampleService : ISampleService
    {
        private readonly ILogger<SampleService> _logger;
        public SampleService(
            ILogger<SampleService> logger
            )
        {
            _logger = logger;
        }
        public void doWork(int param)
        {
            _logger.LogInformation("doWork Start");
            Console.WriteLine($"-- {param} --");
            _logger.LogInformation("doWork End");
        }
    }
}
