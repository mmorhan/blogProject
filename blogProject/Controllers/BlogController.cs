using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace blogProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager cm= new BlogManager(new EfBlogRepository()); 
        public IActionResult Index()
        {
            var values = cm.GetListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values=cm.GetByBlogId(id);
            ViewBag.WriterId =cm.GetWriterId(id);
            ViewBag.id = id;
            return View(values);
        }
    }
}
