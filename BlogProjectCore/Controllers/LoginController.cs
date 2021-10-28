using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.Controllers
{

    public class LoginController : Controller
    {
        AuthManager authManager = new AuthManager(new EfWriterDal());
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Writer writer)
        {
            // var result = authManager.GetWriter(writer.WriterMail, writer.WriterPassword);

            Context context = new Context();
            var result = context.Writers.FirstOrDefault(x=>x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

            if (result != null)
            {
                HttpContext.Session.SetString("username",writer.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
    }
}
