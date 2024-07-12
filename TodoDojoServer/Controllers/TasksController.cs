using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoDojo.Application;

namespace TodoDojoServer.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllOpenTasks()
        {
            var tasks = await _taskService.GetAllOpenTasks();
            return tasks == null ? NotFound() : Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(Guid id)
        {
            var task = await _taskService.GetTaskAsync(id);
            return task == null ? NotFound() : Ok(task);
        }

    }
}
