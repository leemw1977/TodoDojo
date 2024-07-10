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

        // Other methods...
    }
}
