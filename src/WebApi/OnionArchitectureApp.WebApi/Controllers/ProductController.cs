using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureApp.Application.Features.Commands;
using OnionArchitectureApp.Application.Features.Queries.GetAllProducts;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;

namespace OnionArchitectureApp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator mediator;

    public ProductController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProductsAsync()
    {
        var query = new GetAllProductsQuery();
        return Ok(await mediator.Send(query));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductByIdAsync(Guid id)
    {
        var query = new GetProductByIdQuery() { Id = id};
        return Ok(await mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductAsync(CreateProductCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}
