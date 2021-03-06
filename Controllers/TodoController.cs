using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoManager.Data;
using TodoManager.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace TodoManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepo _repository;

        public TodoController(ITodoRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TodoTask>>> GetTasks()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoTask>> GetTaskByID(int id)
        {
            return Ok(await _repository.GetTodoByID(id));
        }

        [HttpGet("person/{person_id}")]
        public async Task<ActionResult<ICollection<TodoTask>>> GetTasksByAssignedUser(int person_id)
        {
            return Ok(await _repository.GetTodosByAssignedUser(person_id));
        }

        [HttpPost]
        public ActionResult<TodoTask> Add(TodoTask todo)
        {
            _repository.Add(todo);
            _repository.RepoSaveChanges();

            return Ok(todo);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<TodoTask>> PutCompleted(int id)
        {
            await _repository.RepoUpdateCompleted(id);
            await _repository.RepoSaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoTask>> Remove(int id)
        {
            _repository.Remove(id);
            await _repository.RepoSaveChangesAsync();

            return Ok();
        }
    }
}