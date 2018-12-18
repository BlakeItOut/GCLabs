using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ModelFirstFramework.Models;

namespace ModelFirstFramework.Controllers
{
    public class IdentityController : Controller
    {
        private UserManager<AppUser> _userManager => HttpContext.GetOwinContext().Get<UserManager<AppUser>>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginModel register)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser() { UserName = register.UserName };
                IdentityResult identityResult = _userManager.Create(user, register.Password);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                ModelState.AddModelError("", identityResult.Errors.FirstOrDefault());
            }

            return View();
        }

        // GET: Identity
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var authManager = HttpContext.GetOwinContext().Authentication;
                AppUser user = _userManager.Find(login.UserName, login.Password);
                if(user != null)
                {
                    var ident = _userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    return RedirectToAction("Index", "DB");
                }
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(login);
        }
    }
}