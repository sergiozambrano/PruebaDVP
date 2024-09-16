using Microsoft.AspNetCore.Mvc;
using PruebaDVP.Infrastructure.Interface;
using PruebaDVP.Infrastructure.Repository;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepositori)
        {
            _taskRepository = taskRepositori;
        }

        public IActionResult GetAll()
        {
            try
            {
                var users = _taskRepository.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Get(int id)
        {
            try
            {
                var user = _taskRepository.Get(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Add(TaskEntity taskEntity)
        {
            try
            {
                var task = _taskRepository.Update(taskEntity);
                return Ok(task);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Update(TaskEntity taskEntity)
        {
            try
            {
                var task = _taskRepository.Update(taskEntity);
                return Ok(task);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var taskDelete = _taskRepository.Delete(id);
                return Ok(taskDelete);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
