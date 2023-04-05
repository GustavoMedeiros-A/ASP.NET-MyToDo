using System;

namespace MyTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}