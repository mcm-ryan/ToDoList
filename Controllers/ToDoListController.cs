using Microsoft.AspNetCore.Mvc;
using ToDoList.Data.Models;

namespace ToDoList.Data.Services
{
    [Route("api/[controller]")]
    public class ToDoListController : Controller
    {
        private readonly IToDoListService _service;
        
        [HttpGet("[action]")]
        public IActionResult GetAllToDoItems()
        {
            var items = _service.GetAllToDoItems();
            return Ok(items);
        }

        [HttpGet("api/ToDoList/{id}")]
        public IActionResult GetToDoItemById(int id)
        {
            var item = _service.GetToDoItemById(id);
            return Ok(item);
        }
    }
}