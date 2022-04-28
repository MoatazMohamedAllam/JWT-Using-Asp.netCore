using JWT_Demo.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly ITokenService _tokenService;
        public AccountController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public ActionResult Login(string username, string password)
        {
            if (username != "admin" && password != "123")
                return Unauthorized();
            return new JsonResult(new { UserName = username, Token = _tokenService.CreateToken(username) });
        }




    }
}
