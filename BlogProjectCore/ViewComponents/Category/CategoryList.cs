using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectCore.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetAll();
            return View(values);
        }
    }
}
