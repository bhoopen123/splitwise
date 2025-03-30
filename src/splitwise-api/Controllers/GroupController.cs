
using Microsoft.AspNetCore.Mvc;
using Splitwise.Api.DTOs;

namespace Splitwise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public GroupController()
        {
        }

        public async Task<ActionResult<SettleGroupResponse>> SettleGroup(SettleGroupRequest request)
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
