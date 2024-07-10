using Microsoft.EntityFrameworkCore;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Domain.Common;
using OnionArchitectureApp.Persistence.Context;

namespace OnionArchitectureApp.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext context;

    public GenericRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<T> AddAsync(T entity)
    {
        context.Entry(entity).State = EntityState.Added;
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await context.Set<T>().FindAsync(id);
    }
}
