namespace ToDoList.Data.Models
{
    public class ToDoItem
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public string Notes { get; set;}
        public DateTime DateCreated { get; set;}
        public DateTime? DateCompleted { get; set;}
    }
}