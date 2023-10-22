using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvSite.Controllers
{
    public class AdminController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            
            var values = userManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Hakkımda()
        {
            var values = userManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Hakkımda(User user)
        {
            userManager.TUpdate(user);
            return RedirectToAction("Index");
        }
    }
}
