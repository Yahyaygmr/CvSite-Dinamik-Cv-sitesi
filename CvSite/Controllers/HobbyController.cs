using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvSite.Controllers
{
    public class HobbyController : Controller
    {
        HobbyManager hobbyManager = new HobbyManager(new EfHobbyDal());
        public IActionResult Index()
        {
            var values = hobbyManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddHobby()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHobby(Hobby hobby)
        {
            hobbyManager.TAdd(hobby);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHobby(int id)
        {
            var values = hobbyManager.TGetByID(id);
            hobbyManager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult EditHobby(int id)
        {
            var values = hobbyManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditHobby(Hobby hobby)
        {
            hobbyManager.TUpdate(hobby);
            return RedirectToAction("Index");
        }
    }
}
