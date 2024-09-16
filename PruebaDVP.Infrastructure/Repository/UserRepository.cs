using PruebaDVP.Context;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(PruebaDvpContext context) : base(context)
        {
        }


    }
}
