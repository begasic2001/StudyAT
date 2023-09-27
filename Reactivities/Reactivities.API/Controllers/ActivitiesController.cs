﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Persistence;
using Reactivities.Domain;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Reactivities.Application.Activities;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        [HttpGet] // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            await Mediator.Send(new Create.Command { Activity = activity });
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id,Activity activity)
        {
            activity.Id = id;
            await Mediator.Send(new Edit.Command { Activity = activity });
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            await Mediator.Send(new Delete.Command { Id = id });
            return NoContent();
        }
    }
}
