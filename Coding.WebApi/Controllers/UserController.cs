using Coding.WebApi.Authorization;
using Coding.WebApi.Models;
using Coding.WebApi.Models.Dtos;
using Coding.WebApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Coding.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<UserRegisterDto> Register([FromBody] UserRegisterRequest userRegisterRequest)
        {
            return await _userService.RegisterAsync(userRegisterRequest);
        }

        [HttpPost("Login")]
        public async Task<UserLoginDto> Login([FromBody] UserLoginRequest userLoginRequest)
        { 
            return await _userService.LoginAsync(userLoginRequest); 
        }
    }
}
