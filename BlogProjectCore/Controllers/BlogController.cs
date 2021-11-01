using Business.Concrete;
using Business.FluentValidationRules;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        BlogValidator blogValidator = new BlogValidator();
        [AllowAnonymous]
        public IActionResult BlogGetAllList()
        {
            var getAllBlogs = blogManager.GetBlogListWithCategory();
            return View(getAllBlogs);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.id = id;
            var getBlog = blogManager.GetById(id);
            return View(getBlog);
        }

        public IActionResult BlogListByWriter()
        {
            var getBlogsByWriter = blogManager.GetBlogListWithCategoryByWriter(2);
            return View(getBlogsByWriter);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.categories = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            ValidationResult results = blogValidator.Validate(blog);

            if (results.IsValid)
            {
                blog.WriterId = 2;
                blogManager.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult BlogUpdate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog blog)
        {
            return View();
        }
    }
}



