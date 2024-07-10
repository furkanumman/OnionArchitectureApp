using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Application.Wrappers;
using OnionArchitectureApp.Domain.Entities;

namespace OnionArchitectureApp.Application.Features.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
{
    private readonly IProductRepository productRepository;
    private readonly IMapper mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product);
        return new ServiceResponse<Guid>(product.Id);
    }
}
