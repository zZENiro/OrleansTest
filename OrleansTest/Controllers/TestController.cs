using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrleansTest.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger _logger;

        public TestController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<TestController>();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> ReturnValue([FromQuery] int value)
        {
            

            return new JsonResult(value);
        }
    }
}
