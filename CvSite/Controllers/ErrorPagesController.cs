using Microsoft.AspNetCore.Mvc;

namespace CvSite.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}
