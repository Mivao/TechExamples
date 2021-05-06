using AutofacExample.API.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacExample.API.Providers
{
    public class ExampleProvider : IExampleProvider
    {
        private readonly ILogger<ExampleProvider> logger;
        // Notice the example service is only created once when its setup with the "per request" scope
        private readonly IExampleService service;
        private readonly ITimeProvider timeProvider;

        public ExampleProvider(ILogger<ExampleProvider> logger, ITimeProvider timeProvider, IExampleService service)
        {
            this.logger = logger;
            this.timeProvider = timeProvider;
            this.service = service;

            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleProvider instantiated by IoC container!");
        }
        public void ExampleProviderMethod()
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleProviderMethod called by consuming class");
        }
    }
}
