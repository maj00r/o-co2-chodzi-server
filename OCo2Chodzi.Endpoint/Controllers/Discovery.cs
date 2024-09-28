using Microsoft.AspNetCore.Mvc;

namespace OCo2Chodzi.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Discovery(ILogger<Discovery> logger) : ControllerBase
    {

        private readonly ILogger<Discovery> _logger = logger;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test");
        }
    }
}
