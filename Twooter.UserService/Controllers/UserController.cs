using System;
using Microsoft.AspNetCore.Mvc;

namespace Twooter.UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet]
        public string Get() => "Hello World!";
    }
}
