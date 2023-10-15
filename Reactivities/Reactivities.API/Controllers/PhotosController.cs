using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Photos;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Add.Command command)
        {
            return HandleResult(await Mediator.Send(command));
        }
    }
}
