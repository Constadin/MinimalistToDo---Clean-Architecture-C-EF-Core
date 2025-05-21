using Microsoft.EntityFrameworkCore;
using MinimalistToDoList.Core.Entities;
using MinimalistToDoList.Core.Interfaces;
using MinimalistToDoList.Infrastructure.Data;

namespace MinimalistToDoList.Infrastructure.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TodoTask task)
        {
            await _context.TodoTasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var task = await _context.TodoTasks.FindAsync(id);
            if (task is not null)
            {
                _context.TodoTasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TodoTask>> GetAllAsync()
        {
            return await _context.TodoTasks.ToListAsync();
        }

        public async Task<TodoTask?> GetByIdAsync(Guid id)
        {
            return await _context.TodoTasks.FindAsync(id);
        }

        public async Task UpdateAsync(TodoTask task)
        {
            _context.TodoTasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
