using Microsoft.AspNetCore.Mvc;

namespace TeapotWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeapotController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(418);
        }
    }
}
