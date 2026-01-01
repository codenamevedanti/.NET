using Microsoft.AspNetCore.Mvc;

namespace Attrubute_based_routing.Controllers
{
    [Route("Demo")]
    public class DemoController1 : Controller
    {
        [Route("Demo")]
        public IActionResult Index()
        {
            return View("~/Views/Demo/data.cshtml");
        }

        [Route("Greetings")]
        public string SayHi()
        {

            return "Namaste!!";
        }
    }
}
