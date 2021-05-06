using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> _logger)
        {
            this._logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> HelloWorld()
        {
            _logger.LogInformation("Hello World get request called");
            return Ok("Hello!");
        }

        [HttpGet("{numberToCountTo}")]
        public async Task<IActionResult> LogSomeNumbers(int numberToCountTo)
        {
            for(int i = 1; i <= numberToCountTo; i++)
            {
                _logger.LogInformation("The current value of i is {LoopCountValue}", i);
            }

            return Ok($"Logged numbers up to {numberToCountTo}");
            
        }

        [HttpPost]
        public async Task<IActionResult> ExampleException()
        {
            _logger.LogInformation("Example Exception post request called");
            try
            {
                throw new Exception("Example exception thrown");
            } 
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in ExampleException post call");
                return BadRequest(ex.Message);
            }
        }

    }
}
