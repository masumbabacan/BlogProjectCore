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

    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult ContactInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactInformation(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("BlogGetAllList","Blog");
        }
    }
}

