using Microsoft.AspNetCore.Mvc;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult GetAll()
        {
            var users = _userRepository.GetAll();
            return Ok(users);
        }

        public IActionResult Get(int id) 
        { 
            var user = _userRepository.Get(id);
            return Ok(user);
        }

        //public IActionResult Add(UserEntity userEntity) 
        //{ 

        //}
    }
}
