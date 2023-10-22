using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(User p)
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var datavalue = userManager.TGetList().FirstOrDefault(x => x.UserMail == p.UserMail && x.UserPassword == p.UserPassword);
        //    if (datavalue != null)
        //    {
        //        HttpContext.Session.SetString("username", p.UserMail);
        //        return RedirectToAction("Index", "Main");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var datavalue = userManager.TGetList().FirstOrDefault(x => x.UserMail == user.UserMail && x.UserPassword == user.UserPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}
