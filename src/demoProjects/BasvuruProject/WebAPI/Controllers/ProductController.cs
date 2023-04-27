using Application.Features.ProductFeatures.Command;
using Application.Features.ProductFeatures.Dtos;
using Application.Features.ProductFeatures.Models;
using Application.Features.ProductFeatures.Queries;
using Core.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        protected IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetByCategory(string Category)
        {
            ProductListModel result = await Mediator.Send(new GetListProductByCategoryQuery() { Category=Category, BypassCache = false });
            return Ok(result);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetById getById)
        {
            ProductGetByIdDto result = await Mediator.Send(getById);
            return Ok(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] CreateProductCommand createProductCommand)
        {
            var result = await Mediator.Send(createProductCommand);
            return Ok(result);

        }


    }
}
