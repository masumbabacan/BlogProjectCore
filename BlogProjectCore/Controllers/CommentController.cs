using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddCommentPartial(Comment comment)
        {
            commentManager.Add(comment);
            return RedirectToAction("BlogGetAllList", "Blog");
        }
    }
}
