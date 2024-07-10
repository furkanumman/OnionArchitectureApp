using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Dtos;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Application.Wrappers;

namespace OnionArchitectureApp.Application.Features.Queries.GetAllProducts;

public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
{
    private readonly IProductRepository productRepository;
    private readonly IMapper mapper;

    public GetAllProductsHandler(IProductRepository productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync();
        var viewModel = mapper.Map<List<ProductViewDto>>(products);
        return new ServiceResponse<List<ProductViewDto>>(viewModel);
    }
}
