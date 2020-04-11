using Microsoft.AspNetCore.Mvc;

namespace WebApplicationInDocker.Controllers
{
    [ApiController]
    [Route("health")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                result = "OK"
            });
        }
    }
}