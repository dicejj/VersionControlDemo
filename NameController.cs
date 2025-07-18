using Microsoft.AspNetCore.Mvc;

namespace VersionControlDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Jacob Dice" });
        }
    }
}

