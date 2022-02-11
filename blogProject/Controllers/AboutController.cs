using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager cm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values=cm.GetListAll();
            return View(values);
        }
        public PartialViewResult SocialMedia()
        {
            return PartialView();
        }

    }
}
