using Microsoft.AspNetCore.Mvc;
using TodoDojo.Application;

namespace TodoDojoServer.Controllers
{
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(Guid id)
        {
            var task = await _taskService.GetTaskAsync(id);
            return task == null ? NotFound() : Ok(task);
        }

        // Other actions...
    }
}
