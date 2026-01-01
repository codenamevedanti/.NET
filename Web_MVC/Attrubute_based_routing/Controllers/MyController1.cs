using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Attrubute_based_routing.Controllers
{
    [Route("testform")]
    public class MyController1 : Controller
    {
        [Route("register")]
        public IActionResult Index()
        {
            return View("~/Views/Demo/form.cshtml");
            
        }
    }
}
