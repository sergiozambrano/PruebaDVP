using PruebaDVP.Context;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Infrastructure.Repository
{
    internal class RolRepository : GenericRepository<RolEntity>, IRolRepository
    {
        public RolRepository(PruebaDvpContext context) : base(context)
        {
        }
    }
}
