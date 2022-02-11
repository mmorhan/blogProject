using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogProject.Controllers
{
    public class ErrorPageController : Controller
    {
        [HttpGet("/Index")]
        public IActionResult Index(int code)
        {
            return View();
        }
    }
}
