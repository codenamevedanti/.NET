using Microsoft.AspNetCore.Mvc;
using ReturnTypeofActions.Models;
using System.Diagnostics;
using System.Xml;

namespace ReturnTypeofActions.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes("C:\\Users\\IET\\Desktop\\250845920099\\.NET\\Lab_work\\Web_MVC\\ReturnTypeofActions\\Data\\poem.pdf");
            return File(byteArray, "application/pdf","poem.pdf");
        }
        
        public ActionResult About()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var data = new
            {
                ID = 501,
                Name = "Kapil Dev",
                Address = "Delhi"
            };
            return Json(data); // JSON
        }

        
    }
}
