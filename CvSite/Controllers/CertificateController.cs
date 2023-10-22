using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CvSite.Controllers
{
    public class CertificateController : Controller
    {
        CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());
        public IActionResult Index()
        {
            var values = certificateManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertificate(Certificate certificate)
        {
            certificateManager.TAdd(certificate);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCertificate(int id)
        {
            var values = certificateManager.TGetByID(id);
            certificateManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCertificate(int id)
        {
            var values = certificateManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditCertificate(Certificate certificate)
        {
            certificateManager.TUpdate(certificate);
            return RedirectToAction("Index");
        }
    }
}
