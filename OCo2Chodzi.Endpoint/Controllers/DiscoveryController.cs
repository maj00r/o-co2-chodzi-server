using Microsoft.AspNetCore.Mvc;
using OCo2Chodzi.Service.Ports;

namespace OCo2Chodzi.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoveryController(ILogger<DiscoveryController> logger, IDiscoveryProvider discoveryProvider) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var emissions = await discoveryProvider.GetEmissions();
            return Ok(emissions);
        }
    }
}
