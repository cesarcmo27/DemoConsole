using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Orders;
using Domain;
using Microsoft.AspNetCore.Mvc;
using static Application.Orders.Create;

namespace API.Controllers
{
    public class OrderController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            return Ok(await Mediator.Send(new Create.Command{Order = order}));
        }

    }
}