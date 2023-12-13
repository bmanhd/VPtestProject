using System;
using System.Collections.Generic;
using VPTestProject.Data.EF.Dto;

namespace VPTestProject.Data.EF.Response
{
    public class OrderResponse
    {
        public Guid Id { get; set; }
        public CustomerDto Customer { get; set; }
        public ICollection<ProductDto> Products { get; set; }
        public int? ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
    }
}