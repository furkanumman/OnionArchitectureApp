using AutoMapper;
using OnionArchitectureApp.Application.Dtos;
using OnionArchitectureApp.Application.Features.Commands;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;
using OnionArchitectureApp.Domain.Entities;

namespace OnionArchitectureApp.Application.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Product, ProductViewDto>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
        CreateMap<Product, GetProductByIdViewModel>().ReverseMap();
    }
}
