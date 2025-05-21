using Microsoft.EntityFrameworkCore;
using MinimalistToDoList.Core.Entities;

namespace MinimalistToDoList.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
