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
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        WriterValidator writerValidator = new WriterValidator();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }




        //Partial Views
        public IActionResult WriterNavbarPartial()
        {
            return View();
        }

        public IActionResult WriterFooterPartial()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WriterProfile()
        {
            var writerInformation = writerManager.GetById(2);
            return View(writerInformation);
        }

        [HttpPost]
        public IActionResult WriterProfile(Writer writer)
        {
            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writerManager.Update(writer);
                return RedirectToAction("Index","Dashboard");
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
