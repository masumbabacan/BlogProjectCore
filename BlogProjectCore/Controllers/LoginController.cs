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

    public class LoginController : Controller
    {
        AuthManager authManager = new AuthManager(new EfWriterDal());
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Writer writer)
        {
            var result = authManager.GetWriter(writer.WriterMail, writer.WriterPassword);
            return View();
        }
    }
}
