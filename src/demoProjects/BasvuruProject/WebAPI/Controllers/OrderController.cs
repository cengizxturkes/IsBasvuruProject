using Application.Features.OrderFeatures.Commands;
using Application.Features.OrderFeatures.Dtos;
using Application.Features.OrderFeatures.Queries;
using Application.Features.ProductFeatures.Models;
using Application.Features.ProductFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        protected IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateOrderCommand createOrderCommand)
        {
            CreatedOrderResponse result = await Mediator.Send(createOrderCommand);
            return Created("",result);
        }
    }
}
