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
    public class CommentController:Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            cm.CommentAdd(p);
            return PartialView();
        }


        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetListAll(id);
            return PartialView(values);
        }
    }
}
