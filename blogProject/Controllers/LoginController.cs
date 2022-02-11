using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace blogProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Index(Writer p)
        {
            Context c = new Context();
            var datavalue=c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
                //Session remove async from action to use

                //HttpContext.Session.SetString("username", p.WriterMail);

                //Identity

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };

                var userIdentity = new ClaimsIdentity(claims, "x");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index","Writer");
            }
            return View();
        }

    }
}
