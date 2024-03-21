
using Todo_List_Manager;


internal class Program
{
    static void Main()
    {
        TaskManager taskManager = new();

        int attemtsCount = 0;

        while (attemtsCount < 5)
        {
            // Console.WriteLine(attemtsCount);

            try
            {
                Console.WriteLine("Please enter the task title");
                string? taskTitle = Console.ReadLine();

                if (taskTitle == null) return;

                Console.WriteLine("Please enter the task desciption");
                string? taskDesciption = Console.ReadLine();

                if (taskDesciption == null) return;

                UserTask userTask = new(taskTitle, taskDesciption);
                taskManager.AddUserTask(userTask);  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            attemtsCount++;
        }
         
        Console.WriteLine("\n");


        UserTask? userFirstTask = taskManager.GetFirstUserTask();

        if (userFirstTask != null)
        {
            userFirstTask.Title = "Some another title name";
            userFirstTask.Description = "Blah blah blah";
            userFirstTask.IsCompleted = false;
        }

        taskManager.ShowAllUserTasks();

    }
}
