using Attrubute_based_routing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Attrubute_based_routing.Controllers
{

    [Route("Home")]
    public class HomeController : Controller
    {
        [Route(" ")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
