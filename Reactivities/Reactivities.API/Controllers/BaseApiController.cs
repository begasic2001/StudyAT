using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Core;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => 
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> res)
        {
            if (res == null) return NotFound();
            if (res.IsSuccess && res.Value != null)
                return Ok(res.Value);
            if (res.IsSuccess && res.Value == null)
                return NotFound();
            return BadRequest(res.Error);
        }
    }
}
