using MinimalistToDoList.Core.Enums;

namespace MinimalistToDoList.Core.Entities
{
    public class TodoTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; } = Priority.Medium; // default
    }
}
