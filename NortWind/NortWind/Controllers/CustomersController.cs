using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NortWind.Models.Entities;
using NortWind.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NortWind.Controllers
{
    public class CustomersController : Controller
    {

        NorthwindContext context;

        public CustomersController(NorthwindContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var models = context.GetCustomersForIndex();
            return View(models);
        }
    }
}
