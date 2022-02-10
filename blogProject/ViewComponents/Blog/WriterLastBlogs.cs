﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogProject.ViewComponents.Blog
{
    public class WriterLastBlogs:ViewComponent
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values=cm.GetBlogListByWriter(id);
            return View(values);
        }
    }
}