using Microsoft.EntityFrameworkCore;
using PruebaDVP.Context;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Infrastructure.Repository
{
    public class TaskRepository : GenericRepository<TaskEntity>, ITaskRepository
    {
        public TaskRepository(PruebaDvpContext context) : base(context)
        {
        }

        public Task<List<TaskEntity>> GetTaskUser(int idUser)
        {
            return _entities.Where(t => t.IdUser == idUser).ToListAsync();
        }
    }
}
