
namespace Todo_List_Manager
{
    internal class UserTask
    {
        private string? title;
        private string? description;

        public UserTask(string? title = null, string? description = null, bool isCompleted = false) 
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
        }

        public string? Title
        {
            get => title;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.", nameof(Title));
                }

                if (value.Length > 30)
                {
                    throw new Exception("The Title must have less than 30 characters");
                }

                title = value;
            }
        }

        public string? Description
        {
            get => description;
            set
            {
                if (value != null && value.Length > 60)
                {
                    throw new Exception("The Description must have less than 60 characters");
                }

                description = value;
            }
        }

        public bool IsCompleted { get; set; }

        public string Id { get; private set; }
    }
}
