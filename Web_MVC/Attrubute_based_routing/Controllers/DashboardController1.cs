using Microsoft.AspNetCore.Mvc;

namespace Attrubute_based_routing.Controllers
{
    [Route("[controller]")]
    public class DashboardController1 : Controller
    {
        [Route("[action]")]
        public int  GetAddition(int a,int b)
        {
            return 3+4;
        }
    }
}
