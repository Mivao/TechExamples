using AutofacExample.API.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.API.Services
{
    public class ExampleService : IExampleService
    {
        private readonly ILogger<ExampleService> logger;
        private readonly ITimeProvider timeProvider;

        public ExampleService(ILogger<ExampleService> logger, ITimeProvider timeProvider)
        {
            this.logger = logger;
            this.timeProvider = timeProvider;

            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleService instantiated by IoC container!");
        }

        public void ExampleServiceMethod()
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleServiceMethod called by consuming class");
        }
    }
}
