using Microsoft.AspNetCore.Mvc;

namespace Conventional_routing.Controllers
{
    public class AdminController:Controller
    {
        public string  Index(string nm)
        {
            return nm;
        }

    }
}
