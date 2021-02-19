using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyWebBlog.DataModel;

namespace MyWebBlog.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly Admin _options;
        public AccountController(IOptions<Admin> options)
        {
            _options = options.Value;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Verify(string id, string name )
        {
            if(string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Login");
            }

            ClaimsIdentity identity = null;
            bool isAuthenticate = false;

            if(id == _options.Email && name == _options.Name)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.Role, "Administrator")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("Login");
        }
    }
}