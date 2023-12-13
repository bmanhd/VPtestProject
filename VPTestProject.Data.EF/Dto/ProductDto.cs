using System;

namespace VPTestProject.Data.EF.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public Guid ProductTypeId { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
    }
}
