using Microsoft.AspNetCore.Mvc;
using OrleansTest.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrleansTest.FrontApi.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly IUserService _userService;

        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Result()
        {
            await _userService.DoSomething();

            return new JsonResult(0);
        }
    }
}
