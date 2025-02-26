using Microsoft.EntityFrameworkCore;
using senkron_todo_api.Models;


namespace senkron_todo_api.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Todo> Todos { get; set; }
    }
}
