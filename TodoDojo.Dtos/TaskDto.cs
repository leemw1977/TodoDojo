namespace TodoDojo.Dtos
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        public TaskDto(Guid id, string taskName, DateTime dueDate, string priority, string status)
        {
            Id = id;
            TaskName = taskName;
            DueDate = dueDate;
            Priority = priority;
            Status = status;
        }
    }
}
