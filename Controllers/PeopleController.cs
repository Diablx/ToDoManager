using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoManager.Data.PeopleRepo;
using TodoManager.Models;

namespace TodoManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepo _repository;

        public PeopleController(IPeopleRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Person>>> GetTasks()
        {
            return Ok(await _repository.Get());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetTaskByID(int id)
        {
            return Ok(await _repository.GetPersonByID(id));
        }

        [HttpPost]
        public ActionResult<Person> Add(Person person)
        {
            _repository.Add(person);
             _repository.RepoSaveChanges();

            return Ok(person);
        }
    }
}