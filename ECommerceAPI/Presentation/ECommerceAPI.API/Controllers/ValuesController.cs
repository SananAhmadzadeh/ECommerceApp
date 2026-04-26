using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}
