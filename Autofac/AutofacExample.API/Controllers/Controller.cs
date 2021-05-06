using AutofacExample.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace AutofacExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly IExampleProvider provider;
        private readonly IExampleService service;
        private readonly ITimeProvider timeProvider;
        private readonly ILogger<Controller> logger;

        public Controller(IExampleProvider provider, IExampleService service, ILogger<Controller> logger, ITimeProvider timeProvider)
        {
            this.provider = provider;
            this.service = service;
            this.logger = logger;
            this.timeProvider = timeProvider;

            logger.LogInformation($"{timeProvider.GetTimestamp()} - Controller instantiated by IoC container!");
        }

        [HttpGet("/provider")]
        public IActionResult ProviderCallingRoute() 
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - ProviderCallingRoute called");
            provider.ExampleProviderMethod();
            return Ok();
        }

        [HttpGet("/service")]
        public IActionResult ServiceCallingRoute() 
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - ServiceCallingRoute called");
            service.ExampleServiceMethod();
            return Ok();
        }

        [HttpGet("/providerservice")]
        public IActionResult BothCallingRoute() 
        {
            logger.LogInformation($"{timeProvider.GetTimestamp()} - BothCallingRoute called");
            provider.ExampleProviderMethod();
            service.ExampleServiceMethod();            
            return Ok();
        }
    }
}
