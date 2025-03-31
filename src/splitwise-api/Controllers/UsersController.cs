using Microsoft.AspNetCore.Mvc;
using Splitwise.Api.DTOs;
using Splitwise.DTOs;
using Splitwise.Services;

namespace Splitwise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<RegisterUserResponse>> Register([FromBody] RegisterUserRequest model)
        {
            var user = await userService.RegisterUser(model);

            return await Task.FromResult(new RegisterUserResponse
            {
                UserId = user.Id,
                PhoneNumber = user.Phone,
                UserName = user.Name,

                ResponseStatus = ResponseStatus.Success,
                Message = "User created successfully"
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetById(long id)
        {
            var user = await userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }
            return await Task.FromResult(new UserResponse
            {
                Name = user.Name,
                Phone = user.Phone,
                UserId = user.Id,

                ResponseStatus = ResponseStatus.Success,
                Message = "User details found successfully"
            });
        }
    }
}
