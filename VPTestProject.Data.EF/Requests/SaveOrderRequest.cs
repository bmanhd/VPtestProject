using System;
using System.Collections.Generic;
using MediatR;
using VPTestProject.Data.EF.Dto;
using VPTestProject.Data.EF.Response;

namespace VPTestProject.Data.EF.Requests
{
    public class SaveOrderRequest : IRequest<OrderResponse>
    {
        public CustomerDto Customer { get; set; }
        public ICollection<ProductDto> Products { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
