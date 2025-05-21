using MinimalistToDoList.Shared.Enums;

namespace MinimalistToDoList_Shared.DTOs
{
    public record TodoTaskDto
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public bool IsCompleted { get; init; } = false;
        public DateTime DueDate { get; init; } = DateTime.Now;
        public PriorityDto Priority { get; init; } = PriorityDto.Medium; // default
    }
}
