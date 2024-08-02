using DDDSampleProject.Domain.ValueObjects;

namespace DDDSampleProject.Domain.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IReadOnlyList<TEntity>> GetAll();
    Task<TEntity> GetAsync(BaseId id);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);

}