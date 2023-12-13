using System;
using System.ComponentModel.DataAnnotations;

namespace VPTestProject.Data.EF.Models.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; }
        public bool Active { get; }
        public decimal Price { get; }
    }
}