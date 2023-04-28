using Application.Features.OrderItems.Commands.CreateOrderItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : BaseController
    {
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] CreateOrderItemCommand createOrderItemCommand)
        {
            var result = await Mediator.Send(createOrderItemCommand);
            return Ok(result);

        }
    }
}
