using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager cm = new NewsLetterManager(new EfNewsLetterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p) 
        {
            p.status = true;
            cm.TAdd(p);
            return PartialView();
        }
        
    }
}
