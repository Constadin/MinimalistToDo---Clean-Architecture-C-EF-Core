using MinimalistToDoList.Core.Entities;
using MinimalistToDoList.Infrastructure.Mappings;
using MinimalistToDoList_Shared.Mocks;

namespace MinimalistToDoList.Infrastructure.Data
{
    public static class AppDbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Αν ήδη έχουμε δεδομένα, βγαίνουμε
            if (context.TodoTasks.Any()) return;

            // Μετατρέπουμε τα mock DTOs σε entities
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
