namespace PruebaDVP.Infrastructure.Interface
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity?> Get(int id);
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(int id);
        Task Update(TEntity entity);
        Task Save();
    }
}
