using Microsoft.AspNetCore.Mvc;

namespace NET.Api.Get.Value.From.Route.POC.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TicketController : ControllerBase
    {
        [HttpGet("tickets/{ticketId}")]
        public IActionResult Get([FromRoute] string ticketId, [FromHeader] string? ticketIdHeader)
        {
            var ticketIdFromRoute = HttpContext.GetRouteValue("ticketid");

            var ticketIdFromHeaders = HttpContext?
                .Request
                .Headers["TICKETIDHEADER"]
                .FirstOrDefault();

            return Ok(new { ticketId, ticketIdFromRoute, ticketIdFromHeaders });
        }
    }
}
