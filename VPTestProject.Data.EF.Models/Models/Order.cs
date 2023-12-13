using System;
using System.Collections.Generic;
using VPTestProject.Data.EF.Models.Models;

namespace VPTestProject.Data.EF.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
    }
}