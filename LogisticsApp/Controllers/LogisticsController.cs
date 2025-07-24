using LogisticsApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogisticsController : ControllerBase
    {
        [HttpPost("deliver")]
        public IActionResult DeliverCargo([FromBody] string transportType)
        {
            Logistics logistics;
            
                switch (transportType.ToLower())
                {
                    case "road":
                        logistics = new RoadLogistics();
                        break;
                    case "sea":
                        logistics = new SeaLogistics();
                        break;
                    default:
                        return BadRequest("Invalid transport type. Use 'road' or 'sea'.");
                }
            var result = logistics.PlanDelivery();
            return Ok(result);
        }
    }
}
