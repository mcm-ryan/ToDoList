using Microsoft.AspNetCore.Mvc;
using ToDoList.Data.Models;
using ToDoList.Data.Services;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    public class ToDoListController : Controller
    {
        private readonly IToDoListService _service;

        public ToDoListController(IToDoListService service)
        {
            _service = service;
        }
        
        [HttpGet("[action]")]
        public IActionResult GetToDoList()
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

        [HttpPost("AddToDo")]
        public IActionResult AddToDoItem(ToDoItem toDo)
        {
            _service.AddToDoItem(toDo);
            return Ok(toDo);
        }


        [HttpDelete("api/ToDoList/{id}")]
        public IActionResult DeleteToDoItem(int id) 
        {
            _service.DeleteToDoItem(id);
            return Ok();
        }
    }
}