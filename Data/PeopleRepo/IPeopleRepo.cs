using System.Collections.Generic;
using System.Threading.Tasks;
using TodoManager.Models;

namespace TodoManager.Data.PeopleRepo
{
    public interface IPeopleRepo
    {
        Task<ICollection<Person>> Get();
        Task<Person> GetPersonByID(int id);
    }
}