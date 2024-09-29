using Microsoft.AspNetCore.Mvc;
using OCo2Chodzi.Service.Ports;

namespace OCo2Chodzi.Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AbsorbionController(IAbsorbionCalculator absorbionCalculator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery(Name = "absorbionMassKilo")] double absorbionMassKilo)
    {
        var result = await absorbionCalculator.Compute(Convert.ToDecimal(absorbionMassKilo));
        return Ok(result);
    }

}