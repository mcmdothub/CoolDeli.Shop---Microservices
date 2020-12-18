using Microsoft.AspNetCore.Mvc;

namespace APIGateway.Controllers
{
    [Route("api/gateway")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        [HttpGet("running")]
        public ActionResult Startup()
        {
            return Ok("API Gateway running...");
        }
    }
}
