using System.Collections.Generic;
using TodoManager.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TodoManager.Data
{
    public class PgsqlTodoRepo : ITodoRepo
    {
        private readonly TodoContext _context;

        public PgsqlTodoRepo(TodoContext context)
        {
            _context = context; 
        }
        public async Task<ICollection<TodoTask>> Get()
        {
            return await _context.TodoTasks.Include(p => p.AssignedUser)
                                            .ToListAsync();
        }

        public async Task<TodoTask> GetTodoByID(int id)
        {
            return await _context.TodoTasks.Include(p => p.AssignedUser)
                                            .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<ICollection<TodoTask>> GetTodosByAssignedUser(int person)
        {
            return await _context.TodoTasks.Include(p => p.AssignedUser)
                                .Where(task => task.PersonID == person)
                                .ToListAsync();
        }

        public void Add(TodoTask todo)
        {
            var newToDo = todo;
            _context.TodoTasks.Add(newToDo);
            
            return;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}