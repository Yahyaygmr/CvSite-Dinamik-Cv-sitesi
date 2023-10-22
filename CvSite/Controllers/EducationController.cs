using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvSite.Controllers
{
    public class EducationController : Controller
    {
        EducationManager educationManager = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            var values = educationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            educationManager.TAdd(education);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var values = educationManager.TGetByID(id);
            educationManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var values = educationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            educationManager.TUpdate(education);
            return RedirectToAction("Index");
        }
    }
}
