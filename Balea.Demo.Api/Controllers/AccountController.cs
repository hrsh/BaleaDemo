using Microsoft.AspNetCore.Mvc;

namespace Balea.Demo.Api.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        [HttpGet("u/login")]
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
