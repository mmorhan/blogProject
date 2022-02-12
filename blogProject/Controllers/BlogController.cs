using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blogProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());


        public IActionResult Index()
        {
            var values = cm.GetListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values = cm.GetByBlogId(id);
            ViewBag.WriterId = cm.GetWriterId(id);
            ViewBag.id = id;
            return View(values);

        }

        public IActionResult BlogListByWriter()
        {
            var values = cm.GetBlogListByWriterWithCategory(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.categories = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            Random rand = new Random();
            p.BlogId = rand.Next(100, 10000);
            p.BlogStatus = "true";
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterId = 1;
            BlogValidator validator = new BlogValidator();
            ValidationResult results = validator.Validate(p);
            results.AddToModelState(ModelState, null);
            if (results.IsValid)
            {
                cm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            Blog blog = cm.GetById(id);
            cm.TDelete(blog);
            return RedirectToAction("BlogListByWriter","Blog");

        }
    }
}
