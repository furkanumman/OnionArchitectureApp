using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Persistence.Context;
using OnionArchitectureApp.Persistence.Repositories;

namespace OnionArchitectureApp.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("Products"));
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}
