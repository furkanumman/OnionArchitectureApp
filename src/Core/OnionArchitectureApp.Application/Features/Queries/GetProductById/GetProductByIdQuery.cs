using MediatR;
using OnionArchitectureApp.Application.Wrappers;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById;
public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
{
    public Guid Id { get; set; }
}
