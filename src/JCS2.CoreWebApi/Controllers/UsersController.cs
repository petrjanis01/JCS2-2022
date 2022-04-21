using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JCS2.CoreWebApi.Dtos;
using JCS2.CoreWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace JCS2.CoreWebApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public List<UserBasicDto> GetUsers([FromQuery] int? maxCount)
        {
            return _usersService.GetAllUsers(maxCount);
        }

        [HttpGet("{id}")]
        public UserDto GetUserDetail([FromRoute] int id)
        {
            return _usersService.GetUser(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult CreateUser([FromBody] CreateUserDto dto)
        {
            _usersService.CreateUser(dto);
            return NoContent();
        }
    }
}
