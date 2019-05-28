using Microsoft.AspNetCore.Mvc;

namespace tn_nextgen_helloworld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!!");
        }


    }
}
