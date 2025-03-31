
using Microsoft.AspNetCore.Mvc;
using Splitwise.Api.DTOs;

namespace Splitwise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        public GroupsController()
        {
        }

        [HttpPost("settle-group/{groupId}")]
        public async Task<ActionResult<SettleGroupResponse>> SettleGroup(long groupId)
        {

            // Logic to settle group
            return await Task.FromResult(new SettleGroupResponse
            {
                ResponseStatus = ResponseStatus.Success,
                Message = "Group settled successfully"
            });
        }
    }
}
