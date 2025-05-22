using MinimalistToDoList.Application.Intrefaces;
using MinimalistToDoList.Application.Mappings;
using MinimalistToDoList.Core.Interfaces;
using MinimalistToDoList_Shared.DTOs;

namespace MinimalistToDoList.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<TodoTaskDto>> GetAllTasksAsync()
        {
            var todoEntities = await _todoRepository.GetAllAsync();

            var todoDtos = todoEntities
                .Select(TodoTaskMapper.ToDto)
                .Where(dto => dto != null)
                .Select(dto => dto!) // Use null-forgiving operator to ensure non-nullability
                .ToList();

            return todoDtos;
        }
    }
}
