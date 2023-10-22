using Microsoft.AspNetCore.Mvc;

namespace CvSite.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
