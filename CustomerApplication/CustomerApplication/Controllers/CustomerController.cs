using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerApplication.Controllers
{
    public class CustomerController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Customers = CustomerManager.GettAllCustomers();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            CustomerManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomerController.Index));
        }
    }
}
