using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoManager.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoManager.Data
{
    public class MockTodoRepo : ITodoRepo
    {
        public async Task<ICollection<TodoTask>> Get()
        {
            var todos = new List<TodoTask> {
                new TodoTask{ID=0, Description="Setup api", IsCompleted=false, CreatedOn=new DateTime(2020,02,15)},
                new TodoTask{ID=1, Description="Setup entityframework", IsCompleted=false, CreatedOn=new DateTime(2020,02,15)},
                new TodoTask{ID=2, Description="Setup database", IsCompleted=false, CreatedOn=new DateTime(2020,02,15)},
                new TodoTask{ID=3, Description="look what's happening at postman", IsCompleted=false, CreatedOn=new DateTime(2020,02,15)},
            };

            return await Task.FromResult<ICollection<TodoTask>>(todos);
        }

        public async Task<TodoTask> GetTodoByID(int id)
        {
            return await Task.FromResult<TodoTask>(new TodoTask{ID=1, Description="look what's happening at postman", IsCompleted=false, CreatedOn=new DateTime(2020,02,15)});;
        }

        public void Add(TodoTask task)
        {
            throw new NotImplementedException();
        }

        Task<ICollection<TodoTask>> ITodoRepo.GetTodosByAssignedUser(int person_id)
        {
            throw new NotImplementedException();
        }

        bool ITodoRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}