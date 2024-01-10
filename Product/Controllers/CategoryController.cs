using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Models;

namespace Product.Controllers
{

    public class CategoryController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            Repository.AddCategory(category);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(Repository.Categories);
        }


    }
}