using MediatR;
using OnionArchitectureApp.Application.Dtos;
using OnionArchitectureApp.Application.Wrappers;

namespace OnionArchitectureApp.Application.Features.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
{

}
