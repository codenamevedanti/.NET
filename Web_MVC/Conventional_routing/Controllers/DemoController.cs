using Microsoft.AspNetCore.Mvc;

namespace Conventional_routing.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
