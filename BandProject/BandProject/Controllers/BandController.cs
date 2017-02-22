using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BandProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BandProject.Controllers
{
    public class BandController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = BandManager.GetAllBands();
            ViewBag.bands = model;
            return View();
        }

        public IActionResult Detail(int id)
        {
            var model = BandManager.GetBand(id);
            ViewBag.band = model;
            return View();
        }
    }
}
