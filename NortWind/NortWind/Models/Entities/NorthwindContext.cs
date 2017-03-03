using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NortWind.Models.Entities
{
    public partial class NorthwindContext : DbContext
    {
        
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        
    }
}