using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("first")]
        public string First()
        {
            return "hellllllllllllllo";
        }

        [Authorize]
        [HttpGet("second")]
        public string Second()
        {
            return "helllllllllllo secure";
        }
    }
}
