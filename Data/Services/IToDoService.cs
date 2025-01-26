using Microsoft.AspNetCore.Mvc;
using ToDoList.Data.Models;

namespace ToDoList.Data.Services
{
    public interface IToDoListService
    {
        List<ToDoItem> GetAllToDoItems();
        ToDoItem GetToDoItemById(int id);
        void AddToDoItem(ToDoItem toDo);
        void UpdateToDoItem(int id, ToDoItem toDo);
        void DeleteToDoItem(int id);
    }
}