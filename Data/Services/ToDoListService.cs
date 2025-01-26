using Microsoft.AspNetCore.Http.HttpResults;
using ToDoList.Data.Models;

namespace ToDoList.Data.Services
{
    public class ToDoListService : IToDoListService
    {
        public List<ToDoItem> GetAllToDoItems() => Data.ToDoItems.ToList();

        public ToDoItem GetToDoItemById(int id)
        {
            var item = Data.ToDoItems.Where(x => x.Id == id).First();
            return item;
        }

        public void AddToDoItem(ToDoItem toDo) {
            Data.ToDoItems.Add(toDo);
        }

        public void DeleteToDoItem(int id)
        {
            var itemToDelete = Data.ToDoItems.FirstOrDefault(t => t.Id == id);
            if (itemToDelete != null) {
                Data.ToDoItems.Remove(itemToDelete);
            }
        }

        public void UpdateToDoItem(int id, ToDoItem toDo)
        {
            var itemToUpdate = Data.ToDoItems.FirstOrDefault(t => t.Id == id);
            if (itemToUpdate != null) {
                itemToUpdate.Title = toDo.Title;
                itemToUpdate.Notes = toDo.Notes;
            }
        }
    }
}