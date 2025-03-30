using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Splitwise.Api.DTOs;
using Splitwise.DTOs;

namespace Splitwise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegisterUserResponse>> Register([FromBody] RegisterUserRequest model)
        {
            // Logic to settle group
            return await Task.FromResult(new RegisterUserResponse
            {
                ResponseStatus = ResponseStatus.Success,
                Message = "Group settled successfully"
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetById(long id)
        {
            // Logic to settle group
            return await Task.FromResult(new UserResponse
            {
                Name = "John Doe",
                Phone = "1234567890",
                UserId = id,

                ResponseStatus = ResponseStatus.Success,
                Message = "Group settled successfully"
            });
        }
    }
}
