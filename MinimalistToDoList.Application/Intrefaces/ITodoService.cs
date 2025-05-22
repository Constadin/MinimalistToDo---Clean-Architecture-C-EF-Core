using MinimalistToDoList_Shared.DTOs;

namespace MinimalistToDoList.Application.Intrefaces
{
    public interface ITodoService
    {
        Task<List<TodoTaskDto>> GetAllTasksAsync();
    }
}
