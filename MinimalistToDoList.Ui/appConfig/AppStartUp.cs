using MinimalistToDoList.Application.Intrefaces;

namespace MinimalistToDoList.Ui.appConfig
{
    public class AppStartUp
    {
        private readonly ITodoService _todoService;

        public AppStartUp(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task RunAsync()
        {

            var tasks = await _todoService.GetAllTasksAsync();
 
            Console.WriteLine("----------- Todo List -----------\n");

            foreach (var task in tasks)
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
