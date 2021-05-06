using AutofacExample.API.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace AutofacExample.API.Providers
{
    public class TimeProvider : ITimeProvider
    {
        private readonly ILogger<TimeProvider> logger;
        public TimeProvider(ILogger<TimeProvider> logger)
        {
            this.logger = logger;
            logger.LogInformation($"{GetTimestamp()} - TimeProvider singlton instantiated by IoC container!");
        }

        public string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("hh:mm:ss:fff");
        }
    }
}
