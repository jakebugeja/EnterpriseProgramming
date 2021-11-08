using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWebApp.Controllers
{
    public class BlogsController : Controller
    {
        private IBlogsController blogsService;

        public BlogsController(IBlogsService _blogsService)
        {
            blogsService = _blogsService;
        }
        public IActionResult Index()
        {
            var list = blogsService.GetBlogs();
            return View(list);
        }

        public IAsyncResult actionResult Details (int id)
        {
            return View();
        }
    }
}
