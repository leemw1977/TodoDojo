namespace TodoDojo.Domain
{
    public class Duration
    {
        public double Hours { get; }
        public Duration(double hours)
        {
            if (hours < 0)
                throw new ArgumentException("Duration cannot be negative", nameof(hours));
            Hours = hours;
        }
        // Override Equals and GetHashCode to ensure value equality
        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is Duration other)
                return Hours == other.Hours;
            return false;
        }
        public override int GetHashCode() => Hours.GetHashCode();
        public override string ToString() => $"{Hours} hours";
    }
}

