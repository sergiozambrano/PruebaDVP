using Microsoft.AspNetCore.Mvc;

namespace PruebaDVP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
