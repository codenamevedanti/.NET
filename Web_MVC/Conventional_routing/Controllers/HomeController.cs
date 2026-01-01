using Conventional_routing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Conventional_routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

            { return View(); }
        public ActionResult<string> UserCredentials(string nm, string pwd)
        {
            return $"Username:{nm} ,Password:{pwd}";
        }
    }
}
