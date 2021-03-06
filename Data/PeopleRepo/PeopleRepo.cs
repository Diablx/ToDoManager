using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoManager.Models;

namespace TodoManager.Data.PeopleRepo
{
    public class PeopleRepo : IPeopleRepo
    {
        readonly TodoContext _context;
        public PeopleRepo(TodoContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Person>> Get()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> GetPersonByID(int id)
        {
            return await _context.People.FirstOrDefaultAsync(p => p.ID == id);
        }
    }
}