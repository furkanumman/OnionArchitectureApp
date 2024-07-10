using OnionArchitectureApp.Domain.Common;

namespace OnionArchitectureApp.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> AddAsync(T entity);

    Task<T> GetByIdAsync(Guid id);

    Task<List<T>> GetAllAsync();
}
