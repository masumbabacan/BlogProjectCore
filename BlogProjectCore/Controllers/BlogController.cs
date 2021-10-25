using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IActionResult BlogGetAllList()
        {
            var getAllBlogs = blogManager.GetBlogListWithCategory();
            return View(getAllBlogs);
        }

        public IActionResult BlogDetails(int id)
        {
            var getBlog = blogManager.GetById(id);
            return View(getBlog);
        }
    }
}



