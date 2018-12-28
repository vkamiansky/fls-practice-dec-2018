namespace TaskList.Model
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public TaskModel() { }

        public TaskModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }   
    }
}