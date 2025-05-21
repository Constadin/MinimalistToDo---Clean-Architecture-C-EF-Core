using MinimalistToDoList.Application.Mappings;
using MinimalistToDoList.Core.Entities;
using MinimalistToDoList_Shared.Mocks;

namespace MinimalistToDoList.Infrastructure.Data
{
    public static class AppDbSeeder
    {
        public static void Seed(AppDbContext context)
        {

            if (context.TodoTasks.Any()) return;


            var entities = MocksTodoTasks.Tasks
                .Select(dto => TodoTaskMapper.ToEntity(dto))
                .Where(entity => entity != null)
                .Cast<TodoTask>()
                .ToList();

            context.TodoTasks.AddRange(entities);
            context.SaveChanges();
        }
    }
}
