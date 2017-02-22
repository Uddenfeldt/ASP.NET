using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index(int id)
        //{
        //    return Content($"In home/index, id:{id}");
        //}

        //public IActionResult Contact()
        //{
        //    return Content("In home/contact");
        //}
        //public IActionResult Products(string id)
        //{
        //    return Content($"In home/products, id:{id}");
        //}

        public IActionResult Index (int id)
        {
           var model = DataManager.GetAllBands();
            ViewBag.Bands = model;
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
