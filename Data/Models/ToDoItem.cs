namespace ToDoList.Data.Models
{
    public class ToDoItem
    {
        public required int Id { get; set;}
        public required string Title { get; set;}
        public required string Notes { get; set;}
        public required DateTime DateCreated { get; set;}
        public DateTime? DateCompleted { get; set;}
    }
}