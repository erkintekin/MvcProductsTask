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

    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View(Repository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = Repository.Categories;
            return View();
        }
        public IActionResult Create(Products product)
        {
            Repository.AddProduct(product);
            return RedirectToAction("Index");
        }

    }
}