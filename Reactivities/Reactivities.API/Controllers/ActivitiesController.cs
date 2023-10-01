using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Persistence;
using Reactivities.Domain;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        [HttpGet] // api/activities
        public async Task<IActionResult> GetActivities()
        {
            var res = await Mediator.Send(new List.Query());
            return HandleResult(res);
        }
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
        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id,Activity activity)
        {
            activity.Id = id;
            var res = await Mediator.Send(new Edit.Command { Activity = activity });
            return HandleResult(res);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            var res = await Mediator.Send(new Delete.Command { Id = id });
            return HandleResult(res);
        }
    }
}
