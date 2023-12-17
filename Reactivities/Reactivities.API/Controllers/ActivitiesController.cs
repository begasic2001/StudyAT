using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Persistence;
using Reactivities.Domain;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using Microsoft.AspNetCore.Authorization;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        [Authorize]
        [HttpGet] // api/activities
        public async Task<IActionResult> GetActivities([FromQuery] PagingParams param)
        {
            var res = await Mediator.Send(new List.Query{ Params = param});
            return HandlePageResult(res);
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(Guid id)
        {
            var res =  await Mediator.Send(new Details.Query{Id = id});
            return HandleResult(res);
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            var res = await Mediator.Send(new Create.Command { Activity = activity });
            return HandleResult(res);
        }
        [Authorize(Policy = "IsActivityHost")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Activity activity)
        {
            activity.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Activity = activity }));
        }
        [Authorize(Policy = "IsActivityHost")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            var res = await Mediator.Send(new Delete.Command { Id = id });
            return HandleResult(res);
        }

        [HttpPost("{id}/attend")]
        public async Task<IActionResult> Attend(Guid id)
        {
            var res = await Mediator.Send(new UpdateAttendance.Command { Id=id});
            return HandleResult(res);
        }
    }
}
