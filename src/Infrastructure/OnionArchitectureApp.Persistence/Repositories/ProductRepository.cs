using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Domain.Entities;
using OnionArchitectureApp.Persistence.Context;

namespace OnionArchitectureApp.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
