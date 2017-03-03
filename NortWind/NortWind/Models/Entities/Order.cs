using System;
using System.Collections.Generic;

namespace NortWind.Models.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ShippedDated { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
