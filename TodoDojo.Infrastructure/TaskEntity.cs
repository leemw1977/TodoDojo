using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoDojo.Domain;

namespace TodoDojo.Infrastructure
{
    public class TaskEntity
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime? Deadline { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public double? DurationHours { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public double? CompletedDurationHours { get; set; }
    }

}
