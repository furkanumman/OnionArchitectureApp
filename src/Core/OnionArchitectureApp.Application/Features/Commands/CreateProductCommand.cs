using MediatR;
using OnionArchitectureApp.Application.Wrappers;

namespace OnionArchitectureApp.Application.Features.Commands
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; } = null!;

        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
