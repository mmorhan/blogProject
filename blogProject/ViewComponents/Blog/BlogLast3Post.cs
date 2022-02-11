using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogProject.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke() {

            var values = cm.GetLast3Post();
            return View(values);
        
        }

    }
}
