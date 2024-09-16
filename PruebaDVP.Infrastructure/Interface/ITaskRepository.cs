using PruebaDVP.Model.Entity;

namespace PruebaDVP.Infrastructure.Interface
{
    public interface ITaskRepository : IGenericRepository<TaskEntity>
    {
        Task<List<TaskEntity>> GetTaskUser(int idUser);
    }
}