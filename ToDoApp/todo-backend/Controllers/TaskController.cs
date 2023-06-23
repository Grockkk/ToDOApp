using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ToDoDBContext _toDoDBContext;

        public TaskController(ToDoDBContext toDoDBContext)
        {
            this._toDoDBContext = toDoDBContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Models.Task>> GetTasks()
        {
            return await _toDoDBContext.Tasks.ToListAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public Models.Task? GetTaskById(int id)
        {
            return _toDoDBContext.Tasks.FirstOrDefault(x=>x.id == id);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<Models.Task> AddTask(Models.Task objTask)
        {
            _toDoDBContext.Tasks.Add(objTask);
            await _toDoDBContext.SaveChangesAsync();
            return objTask;
        }

        [HttpPatch]
        [Route("Update/{id}")]
        public async Task<Models.Task> UpdateTask(Models.Task objTask)
        {
            _toDoDBContext.Entry(objTask).State= EntityState.Modified;
            await _toDoDBContext.SaveChangesAsync();
            return objTask;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public bool DeleteTask(int id)
        {
            bool a = false;
            var task = _toDoDBContext.Tasks.Find(id);
            if (task != null)
            {
                a = true;
                _toDoDBContext.Entry(task).State= EntityState.Deleted;
                _toDoDBContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }

    }


}
