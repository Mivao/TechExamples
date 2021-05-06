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
        private readonly ITimeProvider timeProvider;

        public ExampleProvider(ILogger<ExampleProvider> logger, ITimeProvider timeProvider)
        {
            this.logger = logger;
            this.timeProvider = timeProvider;

            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleProvider instantiated by IoC container!");
        }
        public void ExampleProviderMethod()
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - ExampleProviderMethod called by consuming class");
        }
    }
}
