using System.Threading.Tasks;
using TodoDojo.Dtos;
using TodoDojo.Infrastructure;

namespace TodoDojo.Application
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskDto?> GetTaskAsync(Guid id)
        {
            var task = await _taskRepository.GetByIdAsync(id);

            return task == null ? null : new TaskDto(
                task.Id,
                task.TaskName,
                task.Deadline ?? DateTime.UtcNow,
                task.Priority.ToString(),
                task.Status.ToString()
            );
        }

        public async Task<IList<TaskDto>> GetAllOpenTasks()
        {

            var tasks = await _taskRepository.GetAllTasks();

            return tasks.Select(t => new TaskDto(
                t.Id,
                t.TaskName,
                t.Deadline ?? DateTime.UtcNow.AddDays(1),
                t.Priority.ToString(),
                t.Status.ToString()
            )).ToList();
        }
    }
}
