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
    }
}
