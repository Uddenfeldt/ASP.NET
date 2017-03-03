using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApplication.Models
{
    public class CustomerManager
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer{Id = 1, Address = "Kungsgatan 22", CompanyName = "Ikea", EmployeeCount = 10},
            new Customer{Id = 2, Address = "Götgatan 150", CompanyName = "Burger King", EmployeeCount = 5},
            new Customer{Id = 3, Address = "Drottninggatan 15", CompanyName = "Mio", EmployeeCount = 20},

        };

        public static Customer GetCustomer(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }

        internal static void AddCustomer(Customer customer)
        {
            customer.Id = customers.Max(o => o.Id) + 1;
            customers.Add(customer);
        }

        public static Customer[] GettAllCustomers()
        {
            return customers.ToArray();
        }
    }
}
