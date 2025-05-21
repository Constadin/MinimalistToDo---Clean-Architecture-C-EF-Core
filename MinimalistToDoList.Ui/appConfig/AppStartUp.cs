using MinimalistToDoList.Application.Mappings;
using MinimalistToDoList.Core.Interfaces;

namespace MinimalistToDoList.Ui.appConfig
{
    public class AppStartUp
    {
        private readonly ITodoRepository _todoRepository;
        
        public AppStartUp(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task RunAsync()
        {
            
            var todoEntities = await _todoRepository.GetAllAsync();
          
            var todoDtos = todoEntities.Select(TodoTaskMapper.ToDto).Where(dto => dto != null).ToList()!;
 
            Console.WriteLine("----------- Todo List -----------\n");

            foreach (var task in todoDtos)
            {
                Console.WriteLine($"[{(task.IsCompleted ? "x" : " ")}]" +
                                    $" {task.Title}" +
                                    $" - Due: {task.DueDate.ToShortDateString() ?? "No due date"}" +
                                    $" - Priority: {task.Priority}");
                Console.WriteLine($"    Description: {task.Description}");
                Console.WriteLine();
            }

            Console.WriteLine("Πατήστε ένα πλήκτρο για έξοδο...");
            Console.ReadKey();
        }
    }
}
