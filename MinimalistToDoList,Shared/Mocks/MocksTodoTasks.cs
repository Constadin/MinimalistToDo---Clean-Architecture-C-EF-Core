

using MinimalistToDoList.Shared.Enums;
using MinimalistToDoList_Shared.DTOs;

namespace MinimalistToDoList_Shared.Mocks
{
    public static class MocksTodoTasks
    {
        public static List<TodoTaskDto> Tasks = new List<TodoTaskDto>
        {
            new TodoTaskDto
            {
                Title = "Buy groceries",
                Description = "Milk, Bread, Eggs",
                IsCompleted = false,
                DueDate = DateTime.Now.AddDays(2),
                Priority = PriorityDto.High
            },
            new TodoTaskDto
            {
                Title = "Read a book",
                Description = "Finish reading 'The Great Gatsby'",
                IsCompleted = true,
                DueDate = DateTime.Now.AddDays(5),
                Priority = PriorityDto.Low
            },
            new TodoTaskDto
            {
                Title = "Workout",
                Description = "Go to the gym for an hour",
                IsCompleted = false,
                DueDate = DateTime.Now.AddDays(1),
                Priority = PriorityDto.Medium
            }
        };
    }
}
