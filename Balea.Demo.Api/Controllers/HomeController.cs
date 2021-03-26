using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Balea.Demo.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet, Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return Ok("Balea api");
        }
    }
}
