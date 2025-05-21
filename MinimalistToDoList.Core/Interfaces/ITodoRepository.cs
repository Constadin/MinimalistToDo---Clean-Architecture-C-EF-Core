using MinimalistToDoList.Core.Entities;

namespace MinimalistToDoList.Core.Interfaces
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoTask>> GetAllAsync();
        Task<TodoTask?> GetByIdAsync(Guid id);
        Task AddAsync(TodoTask task);
        Task UpdateAsync(TodoTask task);
        Task DeleteAsync(Guid id);
    }
}
