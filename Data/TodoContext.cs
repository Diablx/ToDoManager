using Microsoft.EntityFrameworkCore;
using TodoManager.Models;

namespace TodoManager.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TodoTask> TodoTasks { get; set; }
        public DbSet<Person> People { get; set; }

    }
}