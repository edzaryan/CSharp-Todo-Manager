
namespace Todo_List_Manager
{
    internal class TaskManager
    {
        private List<UserTask> userTasks = new List<UserTask>();

        public void AddUserTask(UserTask task)
        {
            userTasks.Add(task);
        }

        public void DeleteUserTask(string id)
        {
            UserTask? task = userTasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                throw new Exception($"The user task with id {id} is not found !");
            }

            userTasks.Remove(task);
        }

        public void ShowAllUserTasks()
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;

                foreach (var task in userTasks)
                {
                    ShowUserTaskDetails(task.Id);
                }
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
        }


        public void ShowUserTaskDetails(string userTaskId)
        {
            var userTask = userTasks.FirstOrDefault(t => t.Id == userTaskId);

            if (userTask == null)
            {
                throw new Exception($"Task with ID {userTaskId} not found.");
                
            }

            Console.WriteLine("======================================================");
            Console.WriteLine($"Id: {userTask.Id}, \nTitle: {userTask.Title}, \nDescription: {userTask.Description ?? "null"}, \nIsCompleted: {userTask.IsCompleted}");
        }

        public UserTask? GetFirstUserTask()
        {
            return userTasks.FirstOrDefault();
        }
    }
}
