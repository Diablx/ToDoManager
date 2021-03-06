using System.Collections.Generic;
using System.Threading.Tasks;
using TodoManager.Models;

namespace TodoManager.Data
{
    public interface ITodoRepo
    {
         Task<ICollection<TodoTask>> Get();
         Task<TodoTask> GetTodoByID(int id);
         Task<ICollection<TodoTask>> GetTodosByAssignedUser(int person_id);
         void Add(TodoTask task);
         bool RepoSaveChanges();
         Task RepoUpdate(int id);
         Task RepoSaveChangesAsync();

    }
}