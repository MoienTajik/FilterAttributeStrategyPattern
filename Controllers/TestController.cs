using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(bool throwError)
        {
            if (throwError)
                return BadRequest("Something bad happened !");

            return Ok("Hello World !");
        }
    }
}