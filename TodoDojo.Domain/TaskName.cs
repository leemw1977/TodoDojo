namespace TodoDojo.Domain
{
    public class TaskName
    {
        public string Value { get; }
        public TaskName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Task name cannot be empty", nameof(value));
            Value = value;
        }
        // Override Equals and GetHashCode to ensure value equality
        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is TaskName other)
                return Value == other.Value;
            return false;
        }
        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value;
    }
}

