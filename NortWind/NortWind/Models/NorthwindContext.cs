using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace NortWind.Models.Entities
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {
 
        }
       

        internal CustomersIndexVM[] GetCustomersForIndex()
        {
           return this.Customer
                .Where(o => o.City == "Stockholm")
                .Select(o => new CustomersIndexVM
                {
                    CompanyName = o.CompanyName
                })
                .ToArray();
        }
    }
}