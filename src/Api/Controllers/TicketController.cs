using Microsoft.AspNetCore.Mvc;

namespace NET.Api.Get.Value.From.Route.POC.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TicketController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TicketController> _logger;

        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }

        [HttpGet("tickets/{ticketId}")]
        public IActionResult Get([FromRoute] string ticketId)
        {
            var ticketIdFromRoute = HttpContext.GetRouteValue("ticketid");

            return Ok(new {ticketId, ticketIdFromRoute});
        }
    }
}
