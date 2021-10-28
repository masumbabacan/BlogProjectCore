using Business.Concrete;
using Business.FluentValidationRules;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        AuthManager authManager = new AuthManager(new EfWriterDal());
        WriterValidator validationRules = new WriterValidator();

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegister(Writer writer)
        {
            ValidationResult results = validationRules.Validate(writer);
            
            if (results.IsValid)
            {
                authManager.Register(writer);
                return RedirectToAction("BlogGetAllList", "Blog");
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
    }
}
