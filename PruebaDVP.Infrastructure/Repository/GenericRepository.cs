using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PruebaDVP.Context;
using PruebaDVP.Infrastructure.Interface;

namespace PruebaDVP.Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class
    {
        private readonly PruebaDvpContext _context;
        protected DbSet<TEntity> _entities;

        public GenericRepository(PruebaDvpContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            EntityEntry<TEntity> result = await _entities.AddAsync(entity);
            return result.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            TEntity? entity = await Get(id);

            if (entity == null)
                return false;

            _entities.Remove(entity);
            return true;
        }

        public async Task<TEntity?> Get(int id) => await _entities.FindAsync(id);

        public IQueryable<TEntity> GetAll() =>  _entities;

        public Task Save()
        {
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Update(TEntity entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
