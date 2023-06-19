using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Task
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int importance { get; set; }
        public int date { get; set; }
    }
}
