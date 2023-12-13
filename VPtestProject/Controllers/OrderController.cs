using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using VPTestProject.Data.EF.Dto;
using VPTestProject.Data.EF.Requests;
using VPTestProject.Data.EF.Response;

namespace VPtestProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrdersController : Controller
    {
        private readonly ISender _mediator;

        public OrdersController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SavedOrder(SaveOrderRequest orderRequest)
        {


            OrderResponse order = await _mediator.Send(orderRequest);
            return Ok(order);
        }
    }
}
