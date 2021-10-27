using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = blogManager.GetBlogByWriter(2);
            return View(values);
        }
    }
}
