﻿using Microsoft.AspNetCore.Mvc;

using Reactivities.Application.Profiles;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : BaseApiController
    {
        [HttpGet("{username}")]
        public async Task<IActionResult> GetProfile(string username)
        {
            return HandleResult(await Mediator.Send(new Details.Query { UserName = username }));
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Edit.Command command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [HttpGet("{username}/activities")]
        public async Task<IActionResult> GetUserActivities(string username,string predicate)
        {
            Console.WriteLine($"Predicate From Client {predicate}");
            return HandleResult(await Mediator.Send(new ListActivities.Query{ Username = username, Predicate = predicate }));
        }

    }
}