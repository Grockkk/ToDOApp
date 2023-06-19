using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Models
{
    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
           
        
    }
}
