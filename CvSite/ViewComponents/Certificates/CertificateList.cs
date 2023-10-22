using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvSite.ViewComponents.Certificates
{
    public class CertificateList : ViewComponent
    {
        CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());
        public IViewComponentResult Invoke()
        {
            var values = certificateManager.TGetList();
            return View(values);
        }
    }
}
