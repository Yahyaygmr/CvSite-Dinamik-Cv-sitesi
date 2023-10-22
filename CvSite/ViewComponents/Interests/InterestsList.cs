using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvSite.ViewComponents.Interests
{
    public class InterestsList:ViewComponent
    {
        HobbyManager hobbyManager = new HobbyManager(new EfHobbyDal());
        public IViewComponentResult Invoke()
        {
            var values = hobbyManager.TGetList();
            return View(values);
        }
    }
}
