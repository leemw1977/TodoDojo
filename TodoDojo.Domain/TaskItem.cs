namespace TodoDojo.Domain
{
    public class TaskItem
    {
        public Guid Id { get; private set; }
        public TaskName TaskName { get; private set; }
        public DateTime? DueDate { get; private set; }
        public Priority Priority { get; private set; }
        public Duration PlannedDuration { get; private set; }
        public Status Status { get; private set; }
        public Duration CompletedDuration { get; private set; }
        public DateTime? CompletedAt { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public List<Guid> DependencyIds { get; private set; }

        public TaskItem(TaskName taskName, Priority priority, Status status, DateTime? dueDate, Duration plannedDuration)
        {
            Id = Guid.NewGuid();
            TaskName = taskName;
            DueDate = dueDate;
            Priority = priority;
            PlannedDuration = plannedDuration;
            Status = status;
            CompletedDuration = new Duration(0);
            CompletedAt = null;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = null;
            DependencyIds = new List<Guid>();
        }

        // Domain-specific methods
        public void UpdateTaskName(TaskName taskName)
        {
            TaskName = taskName;
            RecordUpdate();
        }

        public void UpdatePriority(Priority priority)
        {
            Priority = priority;
            RecordUpdate();
        }

        public void UpdateStatus(Status status)
        {
            Status = status;
            RecordUpdate();
        }

        public void UpdateDueDate(DateTime? dueDate)
        {
            DueDate = dueDate;
            RecordUpdate();
        }

        public void UpdatePlannedDuration(Duration plannedDuration)
        {
            PlannedDuration = plannedDuration;
            RecordUpdate();
        }

        private void RecordUpdate()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddWorkedHours(Duration hours)
        {
            CompletedDuration = new Duration(CompletedDuration.Hours + hours.Hours);
            RecordUpdate();
        }

        public Duration RemainingDuration()
        {
            return new Duration(PlannedDuration.Hours - CompletedDuration.Hours);
        }

        public void AddDependency(Guid dependencyId)
        {
            DependencyIds.Add(dependencyId);
            RecordUpdate();
        }

        // Factory method for reconstitution
        public static TaskItem Reconstitute(Guid id, TaskName taskName, Priority priority, Status status, DateTime? dueDate, Duration plannedDuration, Duration completedDuration, List<Guid> dependencyIds, DateTime createdAt, DateTime? updatedAt, DateTime? completedAt)
        {
            return new TaskItem(id, taskName, priority, status, dueDate, plannedDuration, completedDuration, dependencyIds, createdAt, updatedAt, completedAt);
        }

        // Private constructor for reconstitution
        private TaskItem(Guid id, TaskName taskName, Priority priority, Status status, DateTime? dueDate, Duration plannedDuration, Duration completedDuration, List<Guid> dependencyIds, DateTime createdAt, DateTime? updatedAt, DateTime? completedAt)
        {
            Id = id;
            TaskName = taskName;
            DueDate = dueDate;
            Priority = priority;
            PlannedDuration = plannedDuration;
            Status = status;
            CompletedDuration = completedDuration;
            CompletedAt = completedAt;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DependencyIds = dependencyIds;
        }
    }
}
